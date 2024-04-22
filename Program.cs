using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var firstList = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToList();
        var secondList = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToList();

        // Пересечение
        Console.WriteLine("Section = " + string.Join(", ", firstList.Intersect(secondList)));

        // Объединение
        Console.WriteLine("Union = " + string.Join(", ", firstList.Union(secondList)));

        // Разница
        Console.WriteLine("Difference = " + string.Join(", ", firstList.Except(secondList)));

        // Сложение
        Console.WriteLine("Addition = " + string.Join(", ", firstList.Concat(secondList)));
    }
}

