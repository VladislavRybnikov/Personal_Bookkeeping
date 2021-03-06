﻿using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Handlers;
using Personal_Bookkeeping.Handlers.BalanceStates;
using System;
using System.Windows.Forms;

namespace Personal_Bookkeeping.View.Forms
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IBalanceState fromCurrency = null;
                double balanceCount = Convert.ToDouble(fromTxtBx.Text);

                if (fromUSDChkBx.Checked && !fromUAHChkBx.Checked && !fromEURChkBx.Checked)
                    fromCurrency = (USDBalanceState)StateFactoryHolder.factory.GetBalanceState("USD");
                else if (!fromUSDChkBx.Checked && fromUAHChkBx.Checked && !fromEURChkBx.Checked)
                    fromCurrency = (UAHBalanceState)StateFactoryHolder.factory.GetBalanceState("UAH");
                else if (!fromUSDChkBx.Checked && !fromUAHChkBx.Checked && fromEURChkBx.Checked)
                    fromCurrency = (EURBalanceState)StateFactoryHolder.factory.GetBalanceState("EUR");
                else
                    throw new Exception();

                IBalance balance = new Balance(balanceCount, fromCurrency);
                
                if (toUSDChkBx.Checked && !toUAHChkBx.Checked && !toEURChkBx.Checked)
                    balance.ConvertToUSD();
                else if (!toUSDChkBx.Checked && toUAHChkBx.Checked && !toEURChkBx.Checked)
                    balance.ConvertToUAH();
                else if (!toUSDChkBx.Checked && !toUAHChkBx.Checked && toEURChkBx.Checked)
                    balance.ConvertToEUR();
                else
                    throw new Exception();

                toTxtBx.Text = balance.GetStrValue();
            }
            catch
            {
                toTxtBx.Text = "error...";
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
