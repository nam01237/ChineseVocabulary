namespace ChineseVocabulary.Controls
{
    partial class UserStateControl
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
            this.userName = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userName.Location = new System.Drawing.Point(89, 13);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(103, 30);
            this.userName.TabIndex = 0;
            this.userName.Text = "사용자";
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = global::ChineseVocabulary.Properties.Resources.PnadaW;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(13, -10);
            this.userPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(70, 70);
            this.userPicture.TabIndex = 1;
            this.userPicture.TabStop = false;
            // 
            // UserStateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserStateControl";
            this.Size = new System.Drawing.Size(240, 60);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox userPicture;
    }
}
