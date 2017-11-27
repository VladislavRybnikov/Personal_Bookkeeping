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
        }

        private void convertorFormBtn_Click(object sender, EventArgs e)
        {
            ConverterForm converter = new ConverterForm();
            converter.Show();
        }

        private void costsFormBtn_Click(object sender, EventArgs e)
        {
            MoneyManagerForm manager = new MoneyManagerForm();
            manager.Show();

        }
    }
}
