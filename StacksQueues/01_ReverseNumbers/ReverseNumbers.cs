using System;
using System.Collections.Generic;
using System.Linq;
class ReverseNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter some integers dividet by space: ");
        string stringValues = Console.ReadLine();
        if (stringValues == "")
        {
            Console.WriteLine();
        }
        else
        {
            Stack<int> input = new Stack<int>(stringValues.Split(' ').Select(Int32.Parse).ToList());

            foreach (var item in input)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }        
    }
}
