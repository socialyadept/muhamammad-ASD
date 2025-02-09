using GradeProcessor.Core;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Running the grades across all functions
List<int> grades = new List<int> { 4, 85, 95, 100 };

// Display all calculations
Console.WriteLine($"Grades: {string.Join(", ", grades)}");
Console.WriteLine($"Average: {GradeProcessor.Core.GradeProcessor.CalculateAverage(grades):F2}");
Console.WriteLine($"Maximum: {GradeProcessor.Core.GradeProcessor.CalculateMaximum(grades)}");
Console.WriteLine($"Median: {GradeProcessor.Core.GradeProcessor.CalculateMedian(grades)}");
