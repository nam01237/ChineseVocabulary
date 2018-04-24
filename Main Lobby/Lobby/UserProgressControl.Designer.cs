namespace ChineseVocabulary.Main_Lobby
{
    partial class UserProgressControl
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
            this.userProgressBar = new System.Windows.Forms.ProgressBar();
            this.userProgress = new System.Windows.Forms.Label();
            this.userLevelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userProgressBar
            // 
            this.userProgressBar.Location = new System.Drawing.Point(107, 26);
            this.userProgressBar.Name = "userProgressBar";
            this.userProgressBar.Size = new System.Drawing.Size(633, 28);
            this.userProgressBar.TabIndex = 0;
            // 
            // userProgress
            // 
            this.userProgress.AutoSize = true;
            this.userProgress.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userProgress.Location = new System.Drawing.Point(755, 26);
            this.userProgress.Name = "userProgress";
            this.userProgress.Size = new System.Drawing.Size(109, 28);
            this.userProgress.TabIndex = 1;
            this.userProgress.Text = "0  /   n";
            // 
            // userLevelCount
            // 
            this.userLevelCount.AutoSize = true;
            this.userLevelCount.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userLevelCount.Location = new System.Drawing.Point(31, 26);
            this.userLevelCount.Name = "userLevelCount";
            this.userLevelCount.Size = new System.Drawing.Size(58, 28);
            this.userLevelCount.TabIndex = 2;
            this.userLevelCount.Text = "n급";
            // 
            // UserProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userLevelCount);
            this.Controls.Add(this.userProgress);
            this.Controls.Add(this.userProgressBar);
            this.Name = "UserProgressControl";
            this.Size = new System.Drawing.Size(906, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar userProgressBar;
        private System.Windows.Forms.Label userProgress;
        private System.Windows.Forms.Label userLevelCount;
    }
}
