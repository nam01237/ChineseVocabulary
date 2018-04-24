namespace ChineseVocabulary.Main_Lobby
{
    partial class Test
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.LblWordProgress = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pictureBox2.Location = new System.Drawing.Point(582, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(12, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.SystemColors.Info;
            this.txtWord.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWord.Location = new System.Drawing.Point(150, 75);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(362, 172);
            this.txtWord.TabIndex = 8;
            this.txtWord.Text = "단어";
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblWordProgress
            // 
            this.LblWordProgress.AutoSize = true;
            this.LblWordProgress.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblWordProgress.Location = new System.Drawing.Point(397, 524);
            this.LblWordProgress.Name = "LblWordProgress";
            this.LblWordProgress.Size = new System.Drawing.Size(63, 24);
            this.LblWordProgress.TabIndex = 10;
            this.LblWordProgress.Text = "0 / n";
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMeaning.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMeaning.Location = new System.Drawing.Point(150, 279);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ReadOnly = true;
            this.txtMeaning.Size = new System.Drawing.Size(362, 203);
            this.txtMeaning.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(303, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(150, 512);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(157, 52);
            this.btnReveal.TabIndex = 12;
            this.btnReveal.Text = "정답보기";
            this.btnReveal.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(355, 583);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(157, 52);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "모르겠어요";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(150, 583);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(157, 52);
            this.btnYes.TabIndex = 14;
            this.btnYes.Text = "알겠어요";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 697);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblWordProgress);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label LblWordProgress;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}