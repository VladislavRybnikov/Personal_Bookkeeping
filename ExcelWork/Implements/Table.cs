using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Implements
{
    public class Table : ITable
    {
        public Dictionary<ICell, string> Data { get; set; }

        public Table()
        {
            Data = new Dictionary<ICell, string>();
        }

        public string GetCellValue(int x, int y)
        {
            string result = null;
            foreach (var item in this.Data)
            {
                if (item.Key.X == x && item.Key.Y == y)
                    result = item.Value;
            }
            return result;
        }
    }
}
