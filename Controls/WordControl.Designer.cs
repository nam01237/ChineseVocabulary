namespace ChineseVocabulary.Controls
{
    partial class WordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.LblWordProgress = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.Color.Snow;
            this.txtMeaning.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtMeaning.Location = new System.Drawing.Point(14, 219);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ReadOnly = true;
            this.txtMeaning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeaning.Size = new System.Drawing.Size(317, 111);
            this.txtMeaning.TabIndex = 0;
            this.txtMeaning.Text = "뜻";
            this.txtMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.Snow;
            this.txtWord.Font = new System.Drawing.Font("Gulim", 55F);
            this.txtWord.Location = new System.Drawing.Point(14, 47);
            this.txtWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(317, 95);
            this.txtWord.TabIndex = 1;
            this.txtWord.Text = "단어";
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblWordProgress
            // 
            this.LblWordProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWordProgress.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblWordProgress.Location = new System.Drawing.Point(168, 18);
            this.LblWordProgress.Name = "LblWordProgress";
            this.LblWordProgress.Size = new System.Drawing.Size(163, 19);
            this.LblWordProgress.TabIndex = 2;
            this.LblWordProgress.Text = "0 / n";
            this.LblWordProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrade
            // 
            this.lblGrade.Font = new System.Drawing.Font("Gulim", 20F);
            this.lblGrade.Location = new System.Drawing.Point(9, 10);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 37);
            this.lblGrade.TabIndex = 30;
            this.lblGrade.Text = "N급";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Font = new System.Drawing.Font("Gulim", 13F);
            this.textBox1.Location = new System.Drawing.Point(14, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(317, 28);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "품사";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Snow;
            this.textBox2.Font = new System.Drawing.Font("Gulim", 30F);
            this.textBox2.Location = new System.Drawing.Point(14, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(317, 49);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "병음";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.LblWordProgress);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtMeaning);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(346, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMeaning;
        public System.Windows.Forms.TextBox txtWord;
        public System.Windows.Forms.Label LblWordProgress;
        public System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
    }
}
