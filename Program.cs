using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // вызов методов,
        // P.S спасибо тому кто придумал эти задания он Дьявол
        Console.WriteLine("Average Salary: " + CalculateAverageSalary());
        DrawStarChart();
        GeneratePrimeNumbers(50);
        Console.WriteLine("Password Valid: " + ValidatePassword("Test@123"));
        GenerateFibonacciSequence(10);
        Console.WriteLine("Daily Pay: " + CalculateDailyPay());
        GenerateMultiplicationTable(7);
        Console.WriteLine("Is Prime: " + IsPrime(29));
    }
    static double CalculateAverageSalary()
    {
        List<double> salaries = new List<double>();
        Console.WriteLine("Enter salaries for each employee. Type 'done' to finish.");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            if (double.TryParse(input, out double salary))
            {
                salaries.Add(salary);
            }
        }
        return salaries.Count > 0 ? salaries.Average() : 0;
    }
    static void DrawStarChart()
    {
        Console.WriteLine("Enter the number of rows for the star chart:");
        int rows = int.Parse(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
    static void GeneratePrimeNumbers(int maxNumber)
    {
        Console.WriteLine($"Prime numbers up to {maxNumber}:");
        for (int i = 2; i <= maxNumber; i++)
        {
            if (IsPrime(i)) Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static bool ValidatePassword(string password)
    {
        return password.Length >= 8 &&
               password.Any(char.IsDigit) &&
               password.Any(ch => "!@#$%^&*()".Contains(ch));
    }
    static void GenerateFibonacciSequence(int count)
    {
        Console.WriteLine($"First {count} Fibonacci numbers:");
        int a = 0, b = 1;
        for (int i = 0; i < count; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
        Console.WriteLine();
    }
    static double CalculateDailyPay()
    {
        Console.WriteLine("Enter hours worked in a day:");
        double hours = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter hourly rate:");
        double rate = double.Parse(Console.ReadLine());
        return hours * rate;
    }
    static void GenerateMultiplicationTable(int number)
    {
        Console.WriteLine($"Multiplication table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
