using System;

namespace ArrStackClass
{
    class TestArrBasedStack
    {
        static void Main()
        {
            ArrayStack<int> test = new ArrayStack<int>();

            test.Push(25);
            test.Push(24);
            test.Push(3);
            int totCount = test.Count;
            for (int i = 0; i < totCount; i++)
            {
                Console.WriteLine(test.Pop());
            }
        }
    }
}