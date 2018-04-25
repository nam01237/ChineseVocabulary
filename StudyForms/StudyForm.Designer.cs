namespace ChineseVocabulary
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
            this.components = new System.ComponentModel.Container();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.wordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsStagedWords = new System.Windows.Forms.BindingSource(this.components);
            this.TestStart = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordControl1 = new ChineseVocabulary.Controls.WordControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStagedWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWords
            // 
            this.dgvWords.AutoGenerateColumns = false;
            this.dgvWords.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.ColumnHeadersVisible = false;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIdDataGridViewTextBoxColumn,
            this.historiesDataGridViewTextBoxColumn});
            this.dgvWords.DataSource = this.bdsStagedWords;
            this.dgvWords.Location = new System.Drawing.Point(24, 71);
            this.dgvWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowTemplate.Height = 27;
            this.dgvWords.Size = new System.Drawing.Size(187, 393);
            this.dgvWords.TabIndex = 0;
            // 
            // wordIdDataGridViewTextBoxColumn
            // 
            this.wordIdDataGridViewTextBoxColumn.DataPropertyName = "WordId";
            this.wordIdDataGridViewTextBoxColumn.HeaderText = "WordId";
            this.wordIdDataGridViewTextBoxColumn.Name = "wordIdDataGridViewTextBoxColumn";
            // 
            // historiesDataGridViewTextBoxColumn
            // 
            this.historiesDataGridViewTextBoxColumn.DataPropertyName = "Histories";
            this.historiesDataGridViewTextBoxColumn.HeaderText = "Histories";
            this.historiesDataGridViewTextBoxColumn.Name = "historiesDataGridViewTextBoxColumn";
            this.historiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // bdsStagedWords
            // 
            this.bdsStagedWords.DataSource = typeof(VocabularyEntities.Word);
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
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(514, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 102);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Gulim", 13F);
            this.button6.Location = new System.Drawing.Point(303, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 42);
            this.button6.TabIndex = 13;
            this.button6.Text = "6급";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Gulim", 13F);
            this.button5.Location = new System.Drawing.Point(247, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "5급";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Gulim", 13F);
            this.button4.Location = new System.Drawing.Point(191, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 42);
            this.button4.TabIndex = 11;
            this.button4.Text = "4급";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Gulim", 13F);
            this.button3.Location = new System.Drawing.Point(135, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "3급";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Gulim", 13F);
            this.button2.Location = new System.Drawing.Point(79, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "2급";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Gulim", 13F);
            this.button1.Location = new System.Drawing.Point(23, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "1급";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pictureBox2.Location = new System.Drawing.Point(593, 265);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(217, 265);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.White;
            this.wordControl1.Location = new System.Drawing.Point(255, 124);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.Size = new System.Drawing.Size(346, 340);
            this.wordControl1.TabIndex = 16;
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 530);
            this.Controls.Add(this.wordControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TestStart);
            this.Controls.Add(this.dgvWords);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyForm";
            this.Text = "학습하기";
            this.Shown += new System.EventHandler(this.StudyForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStagedWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.Button TestStart;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource bdsStagedWords;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.WordControl wordControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiesDataGridViewTextBoxColumn;
    }
}