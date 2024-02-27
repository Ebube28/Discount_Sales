using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        /*Write a program that prints three numbers in three virtual columns on the console.Each column should have a width of 10 characters and
        the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and
        the third – a negative fraction.The last two numbers have to be rounded to the second decimal place.*/ 
        int hexNumber = 255;
        double positiveFraction = 123.456789;
        double negativeFraction = -987.654321;
        // Print three numbers in three virtual columns
        Console.WriteLine($"{"Hexadecimal",-10}: {hexNumber:X}");
        Console.WriteLine($"{"Positive Fraction",-10}: {positiveFraction:F2}");
        Console.WriteLine($"{"Negative Fraction",-10}: {negativeFraction:F2}");




        //Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.         
        Console.Write("Enter the number of integers (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Initialize sum variable
        int sum = 0;
        // Read and sum n numbers
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }
        // Print the sum to the console
        Console.WriteLine($"The sum of the {n} numbers is: {sum}");




       // Write a program that reads an integer number n from the console and prints all numbers in the range[1…n], each on a separate line. 
        // Prompt user for input
        // I used c instead of n because of the previous code i ran which made use of the variable n.
        Console.Write("Enter a positive integer (c): ");
        int c = Convert.ToInt32(Console.ReadLine());
        // Validate input
        if (c <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        // Print numbers in the range [1...n]
        Console.WriteLine($"Numbers in the range [1...{c}]:");
        for (int i = 1; i <= c; i++)
        {
            Console.WriteLine(i);
        }

        //Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
        // Main Method
        int num = 0;
        Console.WriteLine("Fiobonacci Sequence (First 100 numbers):");
        for (int i = 0; i <= num; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        // Recursive method to calculate Fibonacci numbers
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
