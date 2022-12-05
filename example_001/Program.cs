// See https://aka.ms/new-console-template for more information

using System;
// public class MainClass
// {
//     public static void Main()
//     {
//         string line = Console.ReadLine();
//         string[] splitString = line.Split(' ');

//         int a = Convert.ToInt32(splitString[0]);
//         int b = Convert.ToInt32(splitString[1]);
//         int c = Convert.ToInt32(splitString[2]);

        int a = 8;
        int b = 11;
        int c = 16;
        int d = 20;
        
        int minValue = 0;
        int maxValue = 0;

        minValue = maxValue = a;

        if (b < minValue) minValue = b;
        if (b > maxValue) maxValue = b;
        if (c < minValue) minValue = c;
        if (c > maxValue) maxValue = c;
        if (d < minValue) minValue = d;
        if (d > maxValue) maxValue = d;

        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");

//     }
// }
