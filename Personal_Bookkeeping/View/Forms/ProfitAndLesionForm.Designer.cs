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
            this.pageControl = new System.Windows.Forms.TabControl();
            this.lesionPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profitPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pageControl.SuspendLayout();
            this.lesionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.lesionPage);
            this.pageControl.Controls.Add(this.profitPage);
            this.pageControl.Location = new System.Drawing.Point(2, 4);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(480, 413);
            this.pageControl.TabIndex = 0;
            // 
            // lesionPage
            // 
            this.lesionPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lesionPage.Controls.Add(this.pictureBox1);
            this.lesionPage.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesionPage.Location = new System.Drawing.Point(4, 22);
            this.lesionPage.Name = "lesionPage";
            this.lesionPage.Padding = new System.Windows.Forms.Padding(3);
            this.lesionPage.Size = new System.Drawing.Size(472, 387);
            this.lesionPage.TabIndex = 0;
            this.lesionPage.Text = "Add new spending";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Personal_Bookkeeping.Properties.Resources.costs;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(330, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // profitPage
            // 
            this.profitPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.profitPage.Controls.Add(this.pictureBox2);
            this.profitPage.Location = new System.Drawing.Point(4, 22);
            this.profitPage.Name = "profitPage";
            this.profitPage.Padding = new System.Windows.Forms.Padding(3);
            this.profitPage.Size = new System.Drawing.Size(472, 387);
            this.profitPage.TabIndex = 1;
            this.profitPage.Text = "Add new earning";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Personal_Bookkeeping.Properties.Resources.profit;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(313, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 127);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MoneyManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 417);
            this.Controls.Add(this.pageControl);
            this.Name = "MoneyManagerForm";
            this.Text = "Money manager";
            this.pageControl.ResumeLayout(false);
            this.lesionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profitPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageControl;
        private System.Windows.Forms.TabPage lesionPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage profitPage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}