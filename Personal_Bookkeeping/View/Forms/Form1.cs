using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Handlers;
using Personal_Bookkeeping.View.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Personal_Bookkeeping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            registrationPanel.Hide();
            mainPanel.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private static void ShowPanel(Panel panel)
        {
            panel.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            loginPanel.Hide();
            ShowPanel(registrationPanel);
        }

        private void rBackBtn_Click(object sender, EventArgs e)
        {
            registrationPanel.Hide();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void lBackBtn_Click(object sender, EventArgs e)
        {
            registrationPanel.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(registrationPanel);
            ShowPanel(loginPanel);
        }

        private void registerSaveBtn_Click(object sender, EventArgs e)
        {
            IBalanceState currency = null;
            if (USDChkBx.Checked)
                currency = StateFactoryHolder.factory.GetBalanceState(CurrencyType
                    .USD.ToString());
            else if (EURChkBx.Checked)
                currency = StateFactoryHolder.factory.GetBalanceState(CurrencyType
                    .EUR.ToString());
            else if (UAHChkBx.Checked)
                currency = StateFactoryHolder.factory.GetBalanceState(CurrencyType
                    .UAH.ToString());
            Balance balance = new Balance(Convert.ToDouble(rAccountTxtBx.Text), currency);
            AccountManager.Register(rNameTxtBx.Text, rPassTxtBx.Text, balance);

        }
        private void DoneMessage(Label label)
        {
            label.ForeColor = Color.Green;
            label.Text = "Done!";
        }

        private void loginEntrBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
