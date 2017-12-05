using ExcelWork.Abstraction;
using ExcelWork.Implements;
using ExcelWork.Implements.Processors;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Entities.Common.Result;
using System;
using System.Collections.Generic;
using System.IO;

namespace Personal_Bookkeeping.Handlers.Excel
{
    public static class ExcelTransactProcessor
    {
        public static IResult GenerateExcel(IAccount account)
        {
            IResult result = new Result();
            try
            {
                ITable table = new Table();
                table.Data.Add(new Cell(1, 1), ExcelTableType.Time.ToString());
                table.Data.Add(new Cell(1, 2), ExcelTableType.Name.ToString());
                table.Data.Add(new Cell(1, 3), ExcelTableType.Description.ToString());
                table.Data.Add(new Cell(1, 4), ExcelTableType.Type.ToString());
                table.Data.Add(new Cell(1, 5), ExcelTableType.Money.ToString());
                table.Data.Add(new Cell(1, 6), ExcelTableType.Currency.ToString());

                AddTransactionsTable(table, account.Transactions, new Cell(2, 1));

                using (ExcelWriter writer = new ExcelWriter()) 
                {
                    ExcelData data = new ExcelData(1,1, table);
                    writer.Write(data, GetFilePath(account));
                }

                    result.Success = true;
                result.Message = MessageType.Success.ToString();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return new Result();
        }

        private static string GetFilePath(IAccount account)
        {
            void CreateDirectory(string directoryPath)
            {
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);
            }

            string path = Directory.GetCurrentDirectory() + "\\Transactions";
            CreateDirectory(path);
            string accountPath = path + "\\" + account.Name;
            CreateDirectory(accountPath);
            string fileName = string.Format("\\{0}_{1}_pb.xlsx", account.Name, DateTime.Now.ToShortDateString());
            accountPath += fileName;
            return accountPath;
        }

        private static void AddTransactionsTable(ITable table, 
            List<ITransaction> list, ICell startCell)
        {
            int listDiff = startCell.X - 1;
            ICell lastCell = new Cell(list.Count + 1, 6);
            for (int i = startCell.X; i <= lastCell.X; i++)
                for (int j = startCell.Y; j <= lastCell.Y; j++)
                {
                    switch (j) {
                        case 1:
                            table.Data.Add(new Cell(i, j), list[i - listDiff - 1].Time);
                            break;
                        case 2:
                        table.Data.Add(new Cell(i, j), list[i - listDiff - 1].Name);
                            break;
                        case 3:
                        table.Data.Add(new Cell(i, j), list[i - listDiff - 1].Description);
                            break;
                        case 4:
                            table.Data.Add(new Cell(i, j), list[i - listDiff - 1].Type.Value);
                            break;
                        case 5:
                            table.Data.Add(new Cell(i, j), list[i - listDiff - 1]
                                .Amount.Count.ToString("0.00"));
                            break;
                        case 6:
                            table.Data.Add(new Cell(i, j), list[i - listDiff - 1]
                                .Amount.Currency.Name);
                            break;
                    }
                }
        }

    }
}
