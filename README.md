# Function Evolution

A Windows Forms demo that uses a genetic algorithm to fit a polynomial to a set of known points.

## What it does

You give it sample points `(x, y)` in `Data.txt`. It evolves a population of candidate polynomials until one passes close to all of them. The bundled data samples `y = x²`, so a good run converges towards coefficients `0, 0, 1`.

The window has three parts:

- **Population settings**: number of individuals and number of coefficients per individual (the polynomial degree + 1). Changing either restarts the run.
- **Evolution settings**: crossover probability, mutation probability and how many genes a mutation may touch.
- **Evolution control**: run *N* generations in one step, or press Start/Stop to evolve continuously.

Results are shown in two tabs: **Solutions view** lists every individual with its polynomial and fitness, and **Chart view** plots one randomly chosen individual over `x ∈ [0, 10)`.

## How it works

- **Individual**: an array of `double` coefficients, lowest power first. `{c0, c1, c2}` means `c0 + c1·x + c2·x²`. Random starting values are in `[-1, 1)`.
- **Fitness**: the sum of `|known y − predicted y|` over all known points. Lower is better; 0 is a perfect fit.
- **Selection**: tournament selection (best of 3 random individuals) picks the parents, so better individuals are favoured without the rest being ignored.
- **Crossover**: a parent is paired with a second tournament winner and produces 4 children: a single-point crossover, a uniform crossover (each gene from a random parent), a random blend of the two parents (which may slightly extrapolate beyond them), and their average.
- **Mutation**: produces 5 variants of the parent, all changing the same randomly chosen genes: Gaussian noise with a standard deviation of 0.001, 0.01, 0.1 or 1 (fine tuning up to big jumps), and one variant where the gene is replaced by a fresh random value.
- **Generation step**: for each slot in the population a parent is selected, and it may take part in a crossover and/or a mutation (by the configured probabilities). The originals and all new candidates are then ranked by fitness and only the best *N* survive, where *N* is the starting population size.

The starting settings (100 individuals, 3 coefficients, crossover 0.9, mutation 0.9, 2 genes affected) work well for the bundled data: it reaches the noise floor of the data within a few hundred generations. Higher degrees converge more slowly and may need more generations or a larger population.

## Data file

`Data.txt` holds one point per line, `x` and `y` separated by a space, using `.` as the decimal separator:

```
0.5 0.25
1.0 1.00
```

It is copied next to the executable on build and read from the working directory at startup.

## Running

Requires the .NET 10 SDK and Windows (Windows Forms; the chart uses the [ZedGraph](https://www.nuget.org/packages/ZedGraph) NuGet package, and the solution list uses the WebBrowser control).

```bash
dotnet run
```

Building on other platforms works (`EnableWindowsTargeting` is set), but the app only runs on Windows. Restoring ZedGraph prints an `NU1701` warning because the package targets .NET Framework; it is expected.

## Code map

| File | Purpose |
| --- | --- |
| `Program.cs` | Reads `Data.txt` and starts the form |
| `Population.cs` | Individuals, fitness, crossover, mutation, next generation |
| `ApplicationGui.cs` / `.Designer.cs` | The form: settings, run loop, HTML solution list, chart |
