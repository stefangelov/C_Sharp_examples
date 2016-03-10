using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_pr_6_ConnectedAreas
{
    class ConnectedAreasTest
    {
        static char[,] areas = 
        {
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            
        };

        //
        static int numberOfAreas = 0;

        //list of found connected areas
        static List<ConnectedAreas> connAreas = new List<ConnectedAreas>();

        //variable to hold start Positions
        static int[] newStartPosition = {0, 0};

        //search start positions
        static int[] FindStartPosition(char[,] theAreas, char targetSymbol)
        {
            int[] newStartPosition = new int[2];
            for (int i = 0; i < areas.GetLength(0); i++)
            {
                for (int j = 0; j < areas.GetLength(1); j++)
                {
                    if (theAreas[i, j] == targetSymbol)
                    {
                        newStartPosition[0] = i;
                        newStartPosition[1] = j;
                        return newStartPosition;
                    }
                }
            }
            //this is to check if there isn't more connected areas
            newStartPosition[0] = -10;
            newStartPosition[1] = -10;
            return newStartPosition;
        }

        //check if we are in the matrix :)
        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < areas.GetLength(0);
            bool colInRange = col >= 0 && col < areas.GetLength(1);
            return rowInRange && colInRange;
        }

        //the BIG think :)
        static void FindConnectedAreas(int row, int col, char target, char replacement)
        {

            if (!InRange(row, col))
            {
                return;
            }

            if (areas[row, col] == replacement)
            {
                return;
            }

            if (areas[row, col] != target)
            {
                return;
            }

            if (false)
            {

            }

            areas[row, col] = replacement;

            numberOfAreas++;

            // Recursively explore all possible directions
            FindConnectedAreas(row, col - 1, target, replacement); // left
            FindConnectedAreas(row, col + 1, target, replacement); // right
            FindConnectedAreas(row - 1, col, target, replacement); // up
            FindConnectedAreas(row + 1, col, target, replacement); // down
        }

        //print all areas from The list
        static void PrintAreas(List <ConnectedAreas> printAreas)
        {

            //I'm not sure if this query meets the requirements
            var toPrintResult = from item in printAreas
                                orderby item.Area descending,
                                item.StartRow ascending,
                                item.StartCol ascending
                                select item;

            Console.WriteLine("Total areas found: {0}", printAreas.Count);
            int counter = 1;
            foreach (var item in toPrintResult)
            {
                Console.WriteLine("Area #{0} at {1}", counter, item.ToString());
                counter++;
            }
        }

        static void Main()
        {
            //serarch for first start position
            int[] start = new int[2];

            while(true)
            {
                start = FindStartPosition(areas, ' ');

                if (start[0] == -10 || start[1] == -10)
                {
                    break;
                }

                FindConnectedAreas(start[0], start[1], ' ', 'v');

                connAreas.Add(new ConnectedAreas(start[0], start[1], numberOfAreas));

                numberOfAreas = 0;
            }
            
            //go to print method to order and print areas
            PrintAreas(connAreas);
        }
    }
}
