using System;

namespace _06_pr_6_ConnectedAreas
{
    public class ConnectedAreas
    {
        public ConnectedAreas(int row, int col, int area)
        {
            StartRow = row;
            StartCol = col;
            Area = area;
        }
        public int StartRow { get; set; }
        public int StartCol { get; set; }
        public int Area { get; set; }

        public override string ToString()
        {
            string result = "";

            result += "at (" + StartRow + ", " + StartCol + ") "
                + "size: " + Area;

            return result;
        }
    }
}
