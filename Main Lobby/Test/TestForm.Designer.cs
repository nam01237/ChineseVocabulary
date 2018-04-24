namespace ChineseVocabulary.Main_Lobby
{
    partial class TestForm
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
            this.LblWordProgress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWordProgress
            // 
            this.LblWordProgress.AutoSize = true;
            this.LblWordProgress.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblWordProgress.Location = new System.Drawing.Point(284, 53);
            this.LblWordProgress.Name = "LblWordProgress";
            this.LblWordProgress.Size = new System.Drawing.Size(54, 19);
            this.LblWordProgress.TabIndex = 10;
            this.LblWordProgress.Text = "0 / n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(21, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReveal
            // 
            this.btnReveal.BackColor = System.Drawing.Color.White;
            this.btnReveal.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnReveal.Location = new System.Drawing.Point(310, 299);
            this.btnReveal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(28, 31);
            this.btnReveal.TabIndex = 12;
            this.btnReveal.Text = "답";
            this.btnReveal.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(82, 387);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 42);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "모르겠어요";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(208, 387);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(69, 42);
            this.btnYes.TabIndex = 14;
            this.btnYes.Text = "알겠어요";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.Snow;
            this.txtWord.Font = new System.Drawing.Font("Gulim", 55F);
            this.txtWord.Location = new System.Drawing.Point(21, 84);
            this.txtWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(317, 179);
            this.txtWord.TabIndex = 15;
            this.txtWord.Text = "단어";
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.Color.Snow;
            this.txtMeaning.Font = new System.Drawing.Font("Gulim", 20F);
            this.txtMeaning.Location = new System.Drawing.Point(21, 267);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ReadOnly = true;
            this.txtMeaning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeaning.Size = new System.Drawing.Size(283, 94);
            this.txtMeaning.TabIndex = 16;
            this.txtMeaning.Text = "뜻";
            this.txtMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandared;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(21, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 57);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandagreen;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(283, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 57);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 448);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblWordProgress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWordProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}