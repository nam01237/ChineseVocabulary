namespace ChineseVocabulary.Main_Lobby
{
    partial class StudyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TestStart = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.wordControl1 = new ChineseVocabulary.Main_Lobby.Study.WordControl();
            this.userClassLevelControl1 = new ChineseVocabulary.Main_Lobby.UserClassLevelControl();
            this.testControl1 = new ChineseVocabulary.Main_Lobby.Test.TestControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(187, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // TestStart
            // 
            this.TestStart.Font = new System.Drawing.Font("Gulim", 12F);
            this.TestStart.Location = new System.Drawing.Point(23, 468);
            this.TestStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(188, 39);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "시험보기";
            this.TestStart.UseVisualStyleBackColor = false;
            this.TestStart.Click += new System.EventHandler(this.TestStart_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(475, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 102);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.White;
            this.wordControl1.Location = new System.Drawing.Point(217, 124);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.Size = new System.Drawing.Size(448, 351);
            this.wordControl1.TabIndex = 5;
            // 
            // userClassLevelControl1
            // 
            this.userClassLevelControl1.BackColor = System.Drawing.Color.White;
            this.userClassLevelControl1.Location = new System.Drawing.Point(24, 11);
            this.userClassLevelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userClassLevelControl1.Name = "userClassLevelControl1";
            this.userClassLevelControl1.Size = new System.Drawing.Size(348, 56);
            this.userClassLevelControl1.TabIndex = 2;
            // 
            // testControl1
            // 
            this.testControl1.Location = new System.Drawing.Point(259, 105);
            this.testControl1.Name = "testControl1";
            this.testControl1.Size = new System.Drawing.Size(341, 402);
            this.testControl1.TabIndex = 7;
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 530);
            this.Controls.Add(this.testControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wordControl1);
            this.Controls.Add(this.userClassLevelControl1);
            this.Controls.Add(this.TestStart);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyForm";
            this.Text = "학습하기";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TestStart;
        private UserClassLevelControl userClassLevelControl1;
        private Study.WordControl wordControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Test.TestControl testControl1;
    }
}