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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (AccountHolder.CurrentAccount != null)
            {
                accountNameLbl.Text += AccountHolder.CurrentAccount.Name;
                balanceCountLbl.Text = AccountHolder.CurrentAccount.Balance.GetStrValue();
            }

        }

        private void ConvertorFormBtn_Click(object sender, EventArgs e)
        {
            ConverterForm converter = new ConverterForm();
            converter.Show();
        }

        private void CostsFormBtn_Click(object sender, EventArgs e)
        {
            MoneyManagerForm manager = new MoneyManagerForm();
            manager.Show();

        }

        private void CalendarBtn_Click(object sender, EventArgs e)
        {
            CallendarForm callendar = new CallendarForm();
            callendar.Show();
        }

        private void LogMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogForm logs = new LogForm();
            logs.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            balanceCountLbl.Text = AccountHolder.CurrentAccount.Balance.GetStrValue();
        }

        private void ExelFormBtn_Click(object sender, EventArgs e)
        {
            ExcelForm excel = new ExcelForm();
            excel.Show();
        }

        private void statisticsFormBtn_Click(object sender, EventArgs e)
        {
            StattisticForm statist = new StattisticForm();
            statist.Show();
        }
    }
}
