namespace ChineseVocabulary.Main_Lobby.Study
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.Color.Snow;
            this.txtMeaning.Font = new System.Drawing.Font("Gulim", 20F);
            this.txtMeaning.Location = new System.Drawing.Point(57, 228);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ReadOnly = true;
            this.txtMeaning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeaning.Size = new System.Drawing.Size(317, 93);
            this.txtMeaning.TabIndex = 0;
            this.txtMeaning.Text = "뜻";
            this.txtMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.Snow;
            this.txtWord.Font = new System.Drawing.Font("Gulim", 55F);
            this.txtWord.Location = new System.Drawing.Point(57, 45);
            this.txtWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(317, 179);
            this.txtWord.TabIndex = 1;
            this.txtWord.Text = "단어";
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblWordProgress
            // 
            this.LblWordProgress.AutoSize = true;
            this.LblWordProgress.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblWordProgress.Location = new System.Drawing.Point(320, 14);
            this.LblWordProgress.Name = "LblWordProgress";
            this.LblWordProgress.Size = new System.Drawing.Size(54, 19);
            this.LblWordProgress.TabIndex = 2;
            this.LblWordProgress.Text = "0 / n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pictureBox2.Location = new System.Drawing.Point(380, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(5, 141);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gulim", 20F);
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "N급";
            // 
            // WordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblWordProgress);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtMeaning);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordControl";
            this.Size = new System.Drawing.Size(431, 402);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label LblWordProgress;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
