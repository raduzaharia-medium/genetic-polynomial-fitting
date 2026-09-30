namespace FunctionEvolution;

/// <summary>A candidate polynomial (coefficients in ascending power order) and its error against the known values.</summary>
public sealed record Individual(double[] Coefficients, double Fitness);

public sealed class Population
{
    private const int TournamentSize = 3;
    private const double InitialRange = 1;

    /// <summary>Standard deviations tried by a mutation, from fine tuning up to a large jump.</summary>
    private static readonly double[] MutationScales = [0.001, 0.01, 0.1, 1];

    private readonly IReadOnlyDictionary<double, double> knownValues;
    private readonly int size;

    public List<Individual> Individuals { get; private set; }

    public Population(IReadOnlyDictionary<double, double> knownValues, int size, int coefficientCount)
    {
        this.knownValues = knownValues;
        this.size = size;
        Individuals = [.. Enumerable.Range(0, size).Select(_ => Evaluate(RandomVector(coefficientCount))).OrderBy(individual => individual.Fitness)];
    }

    public void NextGeneration(double crossoverProbability, double mutationProbability, int affectedGenes)
    {
        List<Individual> candidates = [.. Individuals];

        for (int i = 0; i < Individuals.Count; i++)
        {
            double[] parent = TournamentSelection().Coefficients;

            if (Random.Shared.NextDouble() < crossoverProbability)
            {
                candidates.AddRange(Crossover(parent, TournamentSelection().Coefficients).Select(Evaluate));
            }
            if (Random.Shared.NextDouble() < mutationProbability)
            {
                candidates.AddRange(Mutation(parent, mutationProbability, affectedGenes).Select(Evaluate));
            }
        }

        Individuals = [.. candidates.OrderBy(individual => individual.Fitness).Take(size)];
    }

    /// <summary>Creates variants of an individual by perturbing randomly chosen genes.</summary>
    public static List<double[]> Mutation(double[] individual, double probability, int affectedGenes)
    {
        List<double[]> result = [.. MutationScales.Select(_ => (double[])individual.Clone()), (double[])individual.Clone()];

        for (int i = 0; i < affectedGenes; i++)
        {
            if (Random.Shared.NextDouble() < probability)
            {
                int gene = Random.Shared.Next(individual.Length);

                for (int k = 0; k < MutationScales.Length; k++) result[k][gene] += MutationScales[k] * NextGaussian();
                result[^1][gene] = individual[gene] + (Random.Shared.NextDouble() * 2 - 1) * InitialRange;
            }
        }

        return result;
    }

    /// <summary>Produces 4 children: a single-point crossover, a uniform crossover, and two blends of the parents.</summary>
    public static List<double[]> Crossover(double[] parent1, double[] parent2)
    {
        List<double[]> result = [.. Enumerable.Range(0, 4).Select(_ => new double[parent1.Length])];
        int cutPoint = Random.Shared.Next(1, Math.Max(2, parent1.Length));
        double blend = Random.Shared.NextDouble() * 1.5 - 0.25;

        for (int i = 0; i < parent1.Length; i++)
        {
            result[0][i] = i < cutPoint ? parent1[i] : parent2[i];
            result[1][i] = Random.Shared.Next(2) == 0 ? parent1[i] : parent2[i];
            result[2][i] = parent1[i] + blend * (parent2[i] - parent1[i]);
            result[3][i] = (parent1[i] + parent2[i]) / 2;
        }

        return result;
    }

    public static double Value(double[] individual, double point)
    {
        double result = individual[0];
        double power = point;

        for (int i = 1; i < individual.Length; i++)
        {
            result += individual[i] * power;
            power *= point;
        }

        return result;
    }

    private Individual TournamentSelection() =>
        Enumerable.Range(0, TournamentSize).Select(_ => Individuals[Random.Shared.Next(Individuals.Count)]).MinBy(individual => individual.Fitness)!;

    private Individual Evaluate(double[] coefficients) => new(coefficients, knownValues.Sum(known => Math.Abs(known.Value - Value(coefficients, known.Key))));

    private static double[] RandomVector(int dimension) => [.. Enumerable.Range(0, dimension).Select(_ => (Random.Shared.NextDouble() * 2 - 1) * InitialRange)];

    /// <summary>A standard normal sample (Box-Muller transform).</summary>
    private static double NextGaussian() => Math.Sqrt(-2 * Math.Log(1 - Random.Shared.NextDouble())) * Math.Cos(2 * Math.PI * Random.Shared.NextDouble());
}
