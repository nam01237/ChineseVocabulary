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
            this.pgbLearn = new System.Windows.Forms.ProgressBar();
            this.lblLearnPer = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbLearn
            // 
            this.pgbLearn.BackColor = System.Drawing.Color.White;
            this.pgbLearn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pgbLearn.Location = new System.Drawing.Point(79, 12);
            this.pgbLearn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgbLearn.Name = "pgbLearn";
            this.pgbLearn.Size = new System.Drawing.Size(357, 22);
            this.pgbLearn.TabIndex = 0;
            // 
            // lblLearnPer
            // 
            this.lblLearnPer.AutoSize = true;
            this.lblLearnPer.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold);
            this.lblLearnPer.Location = new System.Drawing.Point(442, 16);
            this.lblLearnPer.Name = "lblLearnPer";
            this.lblLearnPer.Size = new System.Drawing.Size(62, 14);
            this.lblLearnPer.TabIndex = 1;
            this.lblLearnPer.Text = "0  /   n";
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
            // UserProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblLearnPer);
            this.Controls.Add(this.pgbLearn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProgressControl";
            this.Size = new System.Drawing.Size(523, 45);
            this.Load += new System.EventHandler(this.UserProgressControl_Load);
            this.Enter += new System.EventHandler(this.UserProgressControl_Enter);
            this.Leave += new System.EventHandler(this.UserProgressControl_Leave);
            this.MouseEnter += new System.EventHandler(this.UserProgressControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserProgressControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbLearn;
        private System.Windows.Forms.Label lblLearnPer;
        public System.Windows.Forms.Label lblGrade;
    }
}
