using System.Globalization;
using FunctionEvolution;

ApplicationConfiguration.Initialize();
Application.Run(new ApplicationGui(ReadKnownValues("Data.txt")));

static Dictionary<double, double> ReadKnownValues(string fileName) =>
    File.ReadLines(fileName)
        .Select(line => line.Split(' '))
        .ToDictionary(
            parts => double.Parse(parts[0], CultureInfo.InvariantCulture),
            parts => double.Parse(parts[1], CultureInfo.InvariantCulture));
