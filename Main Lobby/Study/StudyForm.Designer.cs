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
            this.wordControl1 = new ChineseVocabulary.Main_Lobby.Study.WordControl();
            this.userClassLevelControl1 = new ChineseVocabulary.Main_Lobby.UserClassLevelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(214, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // TestStart
            // 
            this.TestStart.Font = new System.Drawing.Font("Gulim", 12F);
            this.TestStart.Location = new System.Drawing.Point(27, 526);
            this.TestStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(215, 49);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "시험보기";
            this.TestStart.UseVisualStyleBackColor = false;
            this.TestStart.Click += new System.EventHandler(this.TestStart_Click);
            // 
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.White;
            this.wordControl1.Location = new System.Drawing.Point(318, 114);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.Size = new System.Drawing.Size(390, 420);
            this.wordControl1.TabIndex = 5;
            // 
            // userClassLevelControl1
            // 
            this.userClassLevelControl1.BackColor = System.Drawing.Color.White;
            this.userClassLevelControl1.Location = new System.Drawing.Point(27, 14);
            this.userClassLevelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userClassLevelControl1.Name = "userClassLevelControl1";
            this.userClassLevelControl1.Size = new System.Drawing.Size(398, 70);
            this.userClassLevelControl1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(589, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 128);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pictureBox2.Location = new System.Drawing.Point(711, 242);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(264, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 594);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wordControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userClassLevelControl1);
            this.Controls.Add(this.TestStart);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyForm";
            this.Text = "학습하기";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TestStart;
        private UserClassLevelControl userClassLevelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Study.WordControl wordControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}