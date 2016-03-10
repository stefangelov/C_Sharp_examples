using System;
using System.Collections.Generic;
using System.Linq;
namespace _01_pr_1_TowrOfHanoi
{
    class TowrOfHanoiTest
    {
        static int stepsTaken = 0;
        private static void MoveDisk(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            stepsTaken++;

            if (bottomDisk == 1)
            {
                destination.Push(source.Pop());
            }
            else
            {
                MoveDisk(bottomDisk - 1, source, spare, destination);

                destination.Push(source.Pop());

                MoveDisk(bottomDisk - 1, spare, destination, source);
            }
        }
        static void Main()
        {
            int numberOfDisks = 0;
            
            Console.Write("Number of Disks: ");
            numberOfDisks = Convert.ToInt32(Console.ReadLine());

            Stack<int> firstRod = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            Stack<int> secondRod = new Stack<int>();
            Stack<int> thirdRod = new Stack<int>();

            MoveDisk(numberOfDisks, firstRod, secondRod, thirdRod);

            Console.WriteLine("Was made {0} steps", stepsTaken);

        }
    }
}
