namespace LinkedStackClass
{
    class TestLinkedStackApp
    {
        static void Main()
        {
            LinkedStack<int> testVariable = new LinkedStack<int>();

            for (int i = 0; i < 10; i++)
            {
                testVariable.Push(i);
            }

            System.Console.WriteLine();
        }
    }
}
