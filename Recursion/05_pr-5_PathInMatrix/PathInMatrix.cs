using System;
using System.Collections.Generic;

namespace _05_pr_5_PathInMatrix
{
    class PathInMatrix
    {
        static char[,] lab = 
        {
            {' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', ' ', '*', ' '},
            {' ', '*', '*', ' ', '*', ' '},
            {' ', '*', 'e', ' ', ' ', ' '},
            {' ', ' ', ' ', '*', ' ', ' '},
        };

        static List<char> path = new List<char>();
        static int numberOfPats = 0;

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        static void FindPathToExit(int row, int col, char direction)
        {
            if (!InRange(row, col))
            {
                return;
            }

            path.Add(direction);

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                PrintPath(path);
                numberOfPats++;
            }

            if (lab[row, col] == ' ')
            {
                // Temporary mark the current cell as visited
                lab[row, col] = 'v';

                // Recursively explore all possible directions
                FindPathToExit(row, col - 1, 'L'); // left
                FindPathToExit(row - 1, col, 'U'); // up
                FindPathToExit(row, col + 1, 'R'); // right
                FindPathToExit(row + 1, col, 'D'); // down

                // Mark back the current cell as free
                lab[row, col] = ' ';
            }

            // Remove the last direction from the path
            path.RemoveAt(path.Count - 1);
        }
        static void PrintPath(List<char> path)
        {
            foreach (var dir in path)
            {
                if (dir != ' ')
                {
                    Console.Write(dir);                    
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            FindPathToExit(0, 0, ' ');
            Console.WriteLine("Total paths found {0}", numberOfPats);
        }
    }
}
