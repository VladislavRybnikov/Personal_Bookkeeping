
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Abstract.Holders;
using Personal_Bookkeeping.Entities.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Personal_Bookkeeping.View.Forms
{
    public partial class StattisticForm : Form
    {
        public StattisticForm()
        {
            InitializeComponent();
            SetAccountStatistic();
        }

        void SetAccountStatistic()
        {

            double GetTransactionSum(string trType)
            {
                double result = 0;
                foreach (var tr in AccountHolder.CurrentAccount.Transactions)
                {
                    if (tr.Type.Value.Equals(trType))
                    {
                        result += tr.Amount.Count;
                    }
                }
                return result;
            }

            if (AccountHolder.CurrentAccount != null)
            {
                foreach (Transaction tr in AccountHolder.CurrentAccount.Transactions)
                {
                    if (tr.Type.Value.Equals(TransactionTypes.Earning.ToString()))
                        StatisticChart.Series["Earnings"].Points.AddXY(tr.Time, tr.Amount.Count);
                    else
                        StatisticChart.Series["Spendings"].Points.AddXY(tr.Time, tr.Amount.Count);
                }

                SpendVsEarnChart.Series["Transaction"].Points.AddXY("Spendings",
                    GetTransactionSum(TransactionTypes.Spending.ToString()));
                SpendVsEarnChart.Series["Transaction"].Points.AddXY("Earnings",
                    GetTransactionSum(TransactionTypes.Earning.ToString()));
            }
        }

        private void StattisticForm_Load(object sender, EventArgs e)
        {

        }
    }
}
