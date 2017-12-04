using Personal_Bookkeeping.Handlers.Excel;
using Personal_Bookkeeping.Holders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
