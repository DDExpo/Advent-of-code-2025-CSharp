using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SolutionDay02
{
static void Main()
    {
        var input = ReadInput("test");

        Console.WriteLine($"Solution: {Solve(input)}");
    }

    private static string[] ReadInput(string path)
    {
        return File.ReadAllLines(path);
    }

    private static long Solve(string[] input)
    {
        Dictionary<char, Func<long, long, long>> ops = new()
        {
            ['+'] = (a, b) => a + b,
            ['*'] = (a, b) => a * b,
        };

        long answer = 0;
        var result = new List<List<string>>();
        var operators = input[^1].Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length - 1; i++)
        {
            var row = new List<string>();
            var matches = Regex.Matches(input[i], @"\s*\d+");
            foreach (Match m in matches)
                row.Add(m.Value);
            result.Add(row);
        }

        return answer;
    }
}