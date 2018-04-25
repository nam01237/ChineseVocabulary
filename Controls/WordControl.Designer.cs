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
            this.txtWordClass = new System.Windows.Forms.TextBox();
            this.txtByeongEum = new System.Windows.Forms.TextBox();
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
            // txtWordClass
            // 
            this.txtWordClass.BackColor = System.Drawing.Color.Snow;
            this.txtWordClass.Font = new System.Drawing.Font("Gulim", 13F);
            this.txtWordClass.Location = new System.Drawing.Point(14, 192);
            this.txtWordClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWordClass.Multiline = true;
            this.txtWordClass.Name = "txtWordClass";
            this.txtWordClass.ReadOnly = true;
            this.txtWordClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWordClass.Size = new System.Drawing.Size(317, 28);
            this.txtWordClass.TabIndex = 31;
            this.txtWordClass.Text = "품사";
            this.txtWordClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtByeongEum
            // 
            this.txtByeongEum.BackColor = System.Drawing.Color.Snow;
            this.txtByeongEum.Font = new System.Drawing.Font("Gulim", 30F);
            this.txtByeongEum.Location = new System.Drawing.Point(14, 139);
            this.txtByeongEum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtByeongEum.Multiline = true;
            this.txtByeongEum.Name = "txtByeongEum";
            this.txtByeongEum.ReadOnly = true;
            this.txtByeongEum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtByeongEum.Size = new System.Drawing.Size(317, 49);
            this.txtByeongEum.TabIndex = 32;
            this.txtByeongEum.Text = "병음";
            this.txtByeongEum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtByeongEum);
            this.Controls.Add(this.txtWordClass);
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
        public System.Windows.Forms.TextBox txtWordClass;
        public System.Windows.Forms.TextBox txtByeongEum;
    }
}
