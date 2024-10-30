// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        int[] array = { 12, 2, 6, 4, 5, };
        Console.WriteLine("все числа:");
        Console.WriteLine(string.Join(", ", array));
        //foreach (int i in array) Console.WriteLine(i + " ");
        int max = array[0];
        int min = array[0];
        foreach (int i in array)
        {
            if (i > max)
                max = i;
            if (i < min)
                min = i;
        }
        Console.WriteLine($"меньшее число:{min}");
        Console.WriteLine($"большее число:{max}");

        Array.Sort( array );
        string result = " ";
        foreach (int i in array) 
        {
            result += i + " ";
        }
        result = result.Trim();
        Console.WriteLine("по возрастанию:" + result);

        Array.Reverse(array);
        string result1 = " ";
        foreach (int i in array)
        {
            result1 += i + " ";
        }
        result = result1.Trim();
        Console.WriteLine("по убыванию :" + result1);
    }
}

