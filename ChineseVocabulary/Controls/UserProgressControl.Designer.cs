namespace ChineseVocabulary.Controls
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
            this.prbMemorize = new System.Windows.Forms.ProgressBar();
            this.lblMemorize = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.pbReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).BeginInit();
            this.SuspendLayout();
            // 
            // prbMemorize
            // 
            this.prbMemorize.BackColor = System.Drawing.Color.White;
            this.prbMemorize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prbMemorize.Location = new System.Drawing.Point(79, 12);
            this.prbMemorize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prbMemorize.Name = "prbMemorize";
            this.prbMemorize.Size = new System.Drawing.Size(357, 22);
            this.prbMemorize.TabIndex = 0;
            // 
            // lblMemorize
            // 
            this.lblMemorize.AutoSize = true;
            this.lblMemorize.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemorize.Location = new System.Drawing.Point(442, 16);
            this.lblMemorize.Name = "lblMemorize";
            this.lblMemorize.Size = new System.Drawing.Size(98, 14);
            this.lblMemorize.TabIndex = 1;
            this.lblMemorize.Text = "2500 / 2500";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGrade.Location = new System.Drawing.Point(15, 12);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 22);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "n급";
            // 
            // pbReset
            // 
            this.pbReset.BackgroundImage = global::ChineseVocabulary.Properties.Resources.reset;
            this.pbReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReset.Location = new System.Drawing.Point(546, 9);
            this.pbReset.Name = "pbReset";
            this.pbReset.Size = new System.Drawing.Size(26, 25);
            this.pbReset.TabIndex = 3;
            this.pbReset.TabStop = false;
            // 
            // UserProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbReset);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblMemorize);
            this.Controls.Add(this.prbMemorize);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProgressControl";
            this.Size = new System.Drawing.Size(589, 45);
            this.Load += new System.EventHandler(this.UserProgressControl_Load);
            this.Enter += new System.EventHandler(this.UserProgressControl_Enter);
            this.Leave += new System.EventHandler(this.UserProgressControl_Leave);
            this.MouseEnter += new System.EventHandler(this.UserProgressControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserProgressControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.Label lblMemorize;
        public System.Windows.Forms.ProgressBar prbMemorize;
        public System.Windows.Forms.PictureBox pbReset;
    }
}
