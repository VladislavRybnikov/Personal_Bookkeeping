namespace Personal_Bookkeeping.View.Forms
{
    partial class ExcelForm
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
            this.borderPicBox = new System.Windows.Forms.PictureBox();
            this.GenerateXLBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borderPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPicBox
            // 
            this.borderPicBox.BackgroundImage = global::Personal_Bookkeeping.Properties.Resources.excelBorder;
            this.borderPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borderPicBox.Location = new System.Drawing.Point(-10, -28);
            this.borderPicBox.Name = "borderPicBox";
            this.borderPicBox.Size = new System.Drawing.Size(414, 213);
            this.borderPicBox.TabIndex = 0;
            this.borderPicBox.TabStop = false;
            // 
            // GenerateXLBtn
            // 
            this.GenerateXLBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateXLBtn.Location = new System.Drawing.Point(76, 251);
            this.GenerateXLBtn.Name = "GenerateXLBtn";
            this.GenerateXLBtn.Size = new System.Drawing.Size(250, 26);
            this.GenerateXLBtn.TabIndex = 1;
            this.GenerateXLBtn.Text = "Generate excel file for today ";
            this.GenerateXLBtn.UseVisualStyleBackColor = true;
            this.GenerateXLBtn.Click += new System.EventHandler(this.GenerateXLBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal Bookeping v1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(33, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "* You can generate xlsx file only if you have Microsoft office";
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(403, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GenerateXLBtn);
            this.Controls.Add(this.borderPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExcelForm";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.borderPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox borderPicBox;
        private System.Windows.Forms.Button GenerateXLBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}