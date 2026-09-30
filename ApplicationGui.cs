using System.Globalization;
using System.Text;
using ZedGraph;

namespace FunctionEvolution;

public partial class ApplicationGui : Form
{
    private readonly IReadOnlyDictionary<double, double> knownValues;
    private Population population;
    private bool running;
    private int generationCounter;

    public ApplicationGui(IReadOnlyDictionary<double, double> knownValues)
    {
        this.knownValues = knownValues;

        InitializeComponent();
        UpdateAlgorithmConfiguration(this, EventArgs.Empty);
    }

    [System.Diagnostics.CodeAnalysis.MemberNotNull(nameof(population))]
    private void UpdateAlgorithmConfiguration(object? sender, EventArgs e)
    {
        generationCounter = 0;
        population = new Population(knownValues, (int)numIndividualCount.Value, (int)numCoefficientCount.Value);

        UpdateSolutionView();
        UpdateChart();
    }

    private void btnEvolve_Click(object? sender, EventArgs e)
    {
        int generations = (int)numGenerations.Value;

        for (int i = 0; i < generations; i++)
        {
            population.NextGeneration((double)numCrossoverProbability.Value, (double)numMutationProbability.Value, (int)numAffectedGenes.Value);
        }
        generationCounter += generations;

        UpdateSolutionView();
        UpdateChart();
    }

    private async void btnStart_Click(object? sender, EventArgs e)
    {
        if (running) return;

        running = true;
        while (running)
        {
            btnEvolve_Click(this, EventArgs.Empty);
            await Task.Delay(1);
        }
    }

    private void btnStop_Click(object? sender, EventArgs e) => running = false;

    private void UpdateSolutionView()
    {
        StringBuilder html = new();

        html.AppendLine("<html>");
        html.AppendLine("  <body>");
        html.AppendLine("      <div style=\"font-family:Tahoma; font-size:13px\">");
        html.AppendLine($"          Current generation: {generationCounter}<br /><br />");

        foreach (Individual individual in population.Individuals)
        {
            double[] coefficients = individual.Coefficients;

            html.Append("          ");
            if (coefficients.Length > 0)
            {
                int i;
                for (i = coefficients.Length - 1; i > 0; i--)
                {
                    string term = i == 1 ? "*x" : $"*x<sup>{i}</sup>";
                    html.Append(CultureInfo.CurrentCulture, $"{coefficients[i]:0.000}{term} + ");
                }
                html.Append(CultureInfo.CurrentCulture, $"{coefficients[i]:0.000} = 0 --> fitness: {individual.Fitness:0.000}");
            }
            html.AppendLine("<br />");
        }

        html.AppendLine("      </div>");
        html.AppendLine("  </body>");
        html.AppendLine("</html>");

        webSolutionView.DocumentText = html.ToString();
    }

    private void UpdateChart()
    {
        double[] selection = population.Individuals[Random.Shared.Next(population.Individuals.Count)].Coefficients;
        PointPairList points = [];

        for (double point = 0; point < 10; point += 0.1) points.Add(point, Population.Value(selection, point));

        gphChart.GraphPane.CurveList.Clear();
        gphChart.GraphPane.AddCurve("Graph of the resulting function", points, Color.RoyalBlue, SymbolType.None);
        gphChart.GraphPane.XAxis.Title.Text = string.Empty;
        gphChart.GraphPane.YAxis.Title.Text = string.Empty;
        gphChart.GraphPane.Title.Text = string.Empty;
        gphChart.AxisChange();
        gphChart.Refresh();
    }
}
