namespace Personal_Bookkeeping.View.Forms
{
    partial class MoneyManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPage = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.lesionPage = new System.Windows.Forms.TabPage();
            this.msgLabel = new System.Windows.Forms.Label();
            this.EURChkBx = new System.Windows.Forms.CheckBox();
            this.UAHChkBx = new System.Windows.Forms.CheckBox();
            this.USDChkBx = new System.Windows.Forms.CheckBox();
            this.descriptTxtBx = new System.Windows.Forms.RichTextBox();
            this.earnButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.spendButton = new System.Windows.Forms.Button();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.listPage.SuspendLayout();
            this.lesionPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pageControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listPage.Controls.Add(this.listView3);
            this.listPage.Location = new System.Drawing.Point(4, 22);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(508, 435);
            this.listPage.TabIndex = 2;
            this.listPage.Text = "Spendings/Earnings";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(6, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(494, 423);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // lesionPage
            // 
            this.lesionPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lesionPage.Controls.Add(this.msgLabel);
            this.lesionPage.Controls.Add(this.EURChkBx);
            this.lesionPage.Controls.Add(this.UAHChkBx);
            this.lesionPage.Controls.Add(this.USDChkBx);
            this.lesionPage.Controls.Add(this.descriptTxtBx);
            this.lesionPage.Controls.Add(this.earnButton);
            this.lesionPage.Controls.Add(this.label4);
            this.lesionPage.Controls.Add(this.label3);
            this.lesionPage.Controls.Add(this.label2);
            this.lesionPage.Controls.Add(this.costTxtBx);
            this.lesionPage.Controls.Add(this.nameTxtBx);
            this.lesionPage.Controls.Add(this.panel1);
            this.lesionPage.Controls.Add(this.spendButton);
            this.lesionPage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesionPage.Location = new System.Drawing.Point(4, 22);
            this.lesionPage.Name = "lesionPage";
            this.lesionPage.Padding = new System.Windows.Forms.Padding(3);
            this.lesionPage.Size = new System.Drawing.Size(508, 435);
            this.lesionPage.TabIndex = 0;
            this.lesionPage.Text = "NEW";
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.BackColor = System.Drawing.Color.Transparent;
            this.msgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msgLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.msgLabel.Location = new System.Drawing.Point(138, 105);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(213, 19);
            this.msgLabel.TabIndex = 15;
            this.msgLabel.Text = "Add name, cost and description";
            // 
            // EURChkBx
            // 
            this.EURChkBx.AutoSize = true;
            this.EURChkBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EURChkBx.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EURChkBx.ForeColor = System.Drawing.Color.Aquamarine;
            this.EURChkBx.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.EURChkBx.Location = new System.Drawing.Point(309, 194);
            this.EURChkBx.Name = "EURChkBx";
            this.EURChkBx.Size = new System.Drawing.Size(57, 27);
            this.EURChkBx.TabIndex = 14;
            this.EURChkBx.Text = "EUR";
            this.EURChkBx.UseVisualStyleBackColor = true;
            // 
            // UAHChkBx
            // 
            this.UAHChkBx.AutoSize = true;
            this.UAHChkBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UAHChkBx.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UAHChkBx.ForeColor = System.Drawing.Color.Aquamarine;
            this.UAHChkBx.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UAHChkBx.Location = new System.Drawing.Point(244, 194);
            this.UAHChkBx.Name = "UAHChkBx";
            this.UAHChkBx.Size = new System.Drawing.Size(59, 27);
            this.UAHChkBx.TabIndex = 13;
            this.UAHChkBx.Text = "UAH";
            this.UAHChkBx.UseVisualStyleBackColor = true;
            // 
            // USDChkBx
            // 
            this.USDChkBx.AutoSize = true;
            this.USDChkBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.USDChkBx.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.USDChkBx.ForeColor = System.Drawing.Color.Aquamarine;
            this.USDChkBx.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.USDChkBx.Location = new System.Drawing.Point(178, 194);
            this.USDChkBx.Name = "USDChkBx";
            this.USDChkBx.Size = new System.Drawing.Size(60, 27);
            this.USDChkBx.TabIndex = 12;
            this.USDChkBx.Text = "USD";
            this.USDChkBx.UseVisualStyleBackColor = true;
            // 
            // descriptTxtBx
            // 
            this.descriptTxtBx.BackColor = System.Drawing.Color.Teal;
            this.descriptTxtBx.ForeColor = System.Drawing.SystemColors.Window;
            this.descriptTxtBx.Location = new System.Drawing.Point(11, 267);
            this.descriptTxtBx.Name = "descriptTxtBx";
            this.descriptTxtBx.Size = new System.Drawing.Size(487, 116);
            this.descriptTxtBx.TabIndex = 0;
            this.descriptTxtBx.Text = "";
            // 
            // earnButton
            // 
            this.earnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.earnButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.earnButton.ForeColor = System.Drawing.Color.Teal;
            this.earnButton.Location = new System.Drawing.Point(257, 389);
            this.earnButton.Name = "earnButton";
            this.earnButton.Size = new System.Drawing.Size(128, 40);
            this.earnButton.TabIndex = 11;
            this.earnButton.Text = "Add earning";
            this.earnButton.UseVisualStyleBackColor = true;
            this.earnButton.Click += new System.EventHandler(this.EarnButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(14, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(14, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // costTxtBx
            // 
            this.costTxtBx.BackColor = System.Drawing.Color.Teal;
            this.costTxtBx.ForeColor = System.Drawing.SystemColors.Window;
            this.costTxtBx.Location = new System.Drawing.Point(17, 194);
            this.costTxtBx.Name = "costTxtBx";
            this.costTxtBx.Size = new System.Drawing.Size(155, 23);
            this.costTxtBx.TabIndex = 8;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.BackColor = System.Drawing.Color.Teal;
            this.nameTxtBx.ForeColor = System.Drawing.SystemColors.Window;
            this.nameTxtBx.Location = new System.Drawing.Point(17, 137);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(349, 23);
            this.nameTxtBx.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Personal_Bookkeeping.Properties.Resources.tittleL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 83);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "New transaction";
            // 
            // spendButton
            // 
            this.spendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spendButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spendButton.ForeColor = System.Drawing.Color.Teal;
            this.spendButton.Location = new System.Drawing.Point(120, 389);
            this.spendButton.Name = "spendButton";
            this.spendButton.Size = new System.Drawing.Size(128, 40);
            this.spendButton.TabIndex = 2;
            this.spendButton.Text = "Add spending";
            this.spendButton.UseVisualStyleBackColor = true;
            this.spendButton.Click += new System.EventHandler(this.SpendButton_Click);
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.lesionPage);
            this.pageControl.Controls.Add(this.listPage);
            this.pageControl.Location = new System.Drawing.Point(1, 13);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(516, 461);
            this.pageControl.TabIndex = 0;
            // 
            // MoneyManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(517, 473);
            this.Controls.Add(this.pageControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MoneyManagerForm";
            this.Text = "Money manager";
            this.listPage.ResumeLayout(false);
            this.lesionPage.ResumeLayout(false);
            this.lesionPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pageControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TabPage lesionPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.RichTextBox descriptTxtBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spendButton;
        private System.Windows.Forms.TabControl pageControl;
        private System.Windows.Forms.Button earnButton;
        private System.Windows.Forms.CheckBox EURChkBx;
        private System.Windows.Forms.CheckBox UAHChkBx;
        private System.Windows.Forms.CheckBox USDChkBx;
        private System.Windows.Forms.Label msgLabel;
    }
}