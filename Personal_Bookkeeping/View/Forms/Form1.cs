using Personal_Bookkeeping.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
