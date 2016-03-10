using System;
using System.Collections.Generic;
class CalculateSequence
{
    static void Main()
    {
        Console.Write("Enter value: ");

        int theInput = Convert.ToInt32(Console.ReadLine());

        Queue<int> temp = new Queue<int>();
        temp.Enqueue(theInput);

        Console.WriteLine(theInput);

        for (int i = 0; i < 50; i++)
        {            
            temp.Enqueue(temp.Peek()+1);
            Console.WriteLine(temp.Peek() + 1);
            
            temp.Enqueue(2 * temp.Peek() + 1);
            Console.WriteLine(2 * temp.Peek() + 1);

            temp.Enqueue(temp.Peek() + 2);
            Console.WriteLine(temp.Peek() + 2);

            temp.Dequeue();

        }
    }
}
