using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Implements
{
    public class Cell : ICell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
