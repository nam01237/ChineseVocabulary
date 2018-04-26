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
            this.lblMeaning = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.TextBox();
            this.LblWordProgress = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblWordClass = new System.Windows.Forms.TextBox();
            this.lblByeongEum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMeaning
            // 
            this.lblMeaning.BackColor = System.Drawing.Color.Snow;
            this.lblMeaning.Font = new System.Drawing.Font("Gulim", 13F);
            this.lblMeaning.Location = new System.Drawing.Point(14, 219);
            this.lblMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMeaning.Multiline = true;
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.ReadOnly = true;
            this.lblMeaning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMeaning.Size = new System.Drawing.Size(317, 111);
            this.lblMeaning.TabIndex = 0;
            this.lblMeaning.Text = "뜻";
            this.lblMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.Snow;
            this.lblWord.Font = new System.Drawing.Font("Gulim", 55F);
            this.lblWord.Location = new System.Drawing.Point(14, 47);
            this.lblWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWord.Multiline = true;
            this.lblWord.Name = "lblWord";
            this.lblWord.ReadOnly = true;
            this.lblWord.Size = new System.Drawing.Size(317, 95);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "단어";
            this.lblWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblWordClass
            // 
            this.lblWordClass.BackColor = System.Drawing.Color.Snow;
            this.lblWordClass.Font = new System.Drawing.Font("Gulim", 13F);
            this.lblWordClass.Location = new System.Drawing.Point(14, 192);
            this.lblWordClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWordClass.Multiline = true;
            this.lblWordClass.Name = "lblWordClass";
            this.lblWordClass.ReadOnly = true;
            this.lblWordClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWordClass.Size = new System.Drawing.Size(317, 28);
            this.lblWordClass.TabIndex = 31;
            this.lblWordClass.Text = "품사";
            this.lblWordClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblByeongEum
            // 
            this.lblByeongEum.BackColor = System.Drawing.Color.Snow;
            this.lblByeongEum.Font = new System.Drawing.Font("Gulim", 30F);
            this.lblByeongEum.Location = new System.Drawing.Point(14, 139);
            this.lblByeongEum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblByeongEum.Multiline = true;
            this.lblByeongEum.Name = "lblByeongEum";
            this.lblByeongEum.ReadOnly = true;
            this.lblByeongEum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblByeongEum.Size = new System.Drawing.Size(317, 49);
            this.lblByeongEum.TabIndex = 32;
            this.lblByeongEum.Text = "병음";
            this.lblByeongEum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblByeongEum);
            this.Controls.Add(this.lblWordClass);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.LblWordProgress);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblMeaning);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(346, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lblMeaning;
        public System.Windows.Forms.TextBox lblWord;
        public System.Windows.Forms.Label LblWordProgress;
        public System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.TextBox lblWordClass;
        public System.Windows.Forms.TextBox lblByeongEum;
    }
}
