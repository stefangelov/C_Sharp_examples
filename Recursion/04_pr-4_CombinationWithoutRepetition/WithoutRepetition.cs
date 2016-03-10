using System;

namespace _04_pr_4_CombinationWithoutRepetition
{
    class WithoutRepetition
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main()
        {
            Console.Write("N = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoops(0, 1);
        }

        static void NestedLoops(int currentLoop, int counter)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int i = counter; i <= numberOfIterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1, i + 1);
            }

        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
