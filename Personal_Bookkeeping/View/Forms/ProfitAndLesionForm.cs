using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using Personal_Bookkeeping.Configurations.Enums;
using Personal_Bookkeeping.Entities.Common;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Enums;
using Personal_Bookkeeping.Handlers;
using Personal_Bookkeeping.Handlers.BalanceStates;
using Personal_Bookkeeping.Holders;
using System;
using System.Windows.Forms;

namespace Personal_Bookkeeping.View.Forms
{
    public partial class MoneyManagerForm : Form
    {
        public MoneyManagerForm()
        {
            InitializeComponent();
            msgLabel.Hide();
        }

        private void SpendButton_Click(object sender, EventArgs e)
            => Transaction(TransactionTypes.Spending.ToString());

        private IDataResult<double> GetBalanceFromString(string value)
        {
            IDataResult<double> result = new DataResult<double>();
            double resultData;
            try
            {
                resultData = Convert.ToDouble(value);
                result.Message = MessageType.Success.ToString();
                result.Success = true;
                result.Data = resultData;
            }
            catch
            {
                result.Success = false;
                result.Message = MessageHolder.GetMessage(MessageType
                    .BalanceFieldError);
            }
            return result;
        }

        private void Transaction(string transactionType)
        {
            try
            {
                msgLabel.Hide();
                if (AccountHolder.CurrentAccount != null)
                {
                    ITransaction transaction = new Transaction();
                    transaction.Name = nameTxtBx.Text;
                    transaction.Description = descriptTxtBx.Text;
                    transaction.Time = DateTime.Now.ToLongTimeString();

                    if(transactionType.Equals(TransactionTypes.Spending.ToString()))
                        transaction.Type = new TransactionType(TransactionTypes
                            .Spending.ToString());
                    else
                        transaction.Type = new TransactionType(TransactionTypes
                            .Earning.ToString());

                    double cost = 0;

                    if (GetBalanceFromString(costTxtBx.Text).Success == true)
                        cost = GetBalanceFromString(costTxtBx.Text).Data;
                    else
                    {
                        msgLabel.Text = GetBalanceFromString(costTxtBx.Text)
                            .Message;
                        throw new Exception();
                    }

                    IBalanceState currency = null;
                    if (USDChkBx.Checked && !UAHChkBx.Checked && !EURChkBx.Checked)
                        currency = (USDBalanceState)StateFactoryHolder.factory
                            .GetBalanceState(CurrencyType.USD.ToString());
                    else if (!USDChkBx.Checked && UAHChkBx.Checked && !EURChkBx.Checked)
                        currency = (UAHBalanceState)StateFactoryHolder.factory
                            .GetBalanceState(CurrencyType.UAH.ToString());
                    else if (!USDChkBx.Checked && !UAHChkBx.Checked && EURChkBx.Checked)
                        currency = (EURBalanceState)StateFactoryHolder.factory
                            .GetBalanceState(CurrencyType.EUR.ToString());
                    else
                    {
                        msgLabel.Text = MessageHolder.GetMessage(MessageType
                            .MultiplyCheckError);
                        throw new Exception();
                    }


                    Balance balance = new Balance(cost, currency);
                    transaction.Amount = balance;

                    if (transactionType.Equals(TransactionTypes.Spending.ToString()))
                        AccountHolder.CurrentAccount.SpendMoney(transaction);
                    else
                        AccountHolder.CurrentAccount.ReceiveMoney(transaction);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                msgLabel.Show();
            }

        }

        private void EarnButton_Click(object sender, EventArgs e) 
            => Transaction(TransactionTypes.Earning.ToString());
    }
}
