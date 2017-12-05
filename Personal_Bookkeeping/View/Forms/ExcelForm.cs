using Personal_Bookkeeping.Abstract.Holders;
using Personal_Bookkeeping.Handlers.Excel;
using System;
using System.Windows.Forms;

namespace Personal_Bookkeeping.View.Forms
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        private void GenerateXLBtn_Click(object sender, EventArgs e)
        {
            Type office = Type.GetTypeFromProgID("Excel.Application");
            if (office == null)
            {
                MessageBox.Show("Excel not installed");
            }
            else
            {
                if (AccountHolder.CurrentAccount != null)
                {
                    ExcelTransactProcessor.GenerateExcel(AccountHolder.CurrentAccount);
                    MessageBox.Show("Done!");
                }
                
            }
        }
    }
}
