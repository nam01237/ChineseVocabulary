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
            this.TestStart = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uscWord = new ChineseVocabulary.Controls.WordControl();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.ganchezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsWord = new System.Windows.Forms.BindingSource(this.components);
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TestStart
            // 
            this.TestStart.Font = new System.Drawing.Font("Gulim", 12F);
            this.TestStart.Location = new System.Drawing.Point(18, 585);
            this.TestStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(215, 49);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "시험보기";
            this.TestStart.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Gulim", 13F);
            this.button6.Location = new System.Drawing.Point(338, 14);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 52);
            this.button6.TabIndex = 13;
            this.button6.Text = "6급";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Gulim", 13F);
            this.button5.Location = new System.Drawing.Point(274, 14);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 52);
            this.button5.TabIndex = 12;
            this.button5.Text = "5급";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Gulim", 13F);
            this.button4.Location = new System.Drawing.Point(210, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 52);
            this.button4.TabIndex = 11;
            this.button4.Text = "4급";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Gulim", 13F);
            this.button3.Location = new System.Drawing.Point(146, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "3급";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Gulim", 13F);
            this.button2.Location = new System.Drawing.Point(82, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "2급";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Gulim", 13F);
            this.button1.Location = new System.Drawing.Point(18, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "1급";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pbNext
            // 
            this.pbNext.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pbNext.Location = new System.Drawing.Point(586, 265);
            this.pbNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(44, 48);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 15;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbPrev
            // 
            this.pbPrev.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pbPrev.Location = new System.Drawing.Point(210, 265);
            this.pbPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(46, 48);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrev.TabIndex = 14;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.pbPrev_Click);
            // 
            // uscWord
            // 
            this.uscWord.BackColor = System.Drawing.Color.White;
            this.uscWord.Location = new System.Drawing.Point(283, 155);
            this.uscWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscWord.Name = "uscWord";
            this.uscWord.Size = new System.Drawing.Size(395, 425);
            this.uscWord.TabIndex = 16;
            // 
            // dgvWords
            // 
            this.dgvWords.AutoGenerateColumns = false;
            this.dgvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWords.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.ColumnHeadersVisible = false;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganchezaDataGridViewTextBoxColumn});
            this.dgvWords.DataSource = this.bdsWord;
            this.dgvWords.Location = new System.Drawing.Point(18, 90);
            this.dgvWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.RowTemplate.Height = 23;
            this.dgvWords.Size = new System.Drawing.Size(215, 489);
            this.dgvWords.TabIndex = 17;
            this.dgvWords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellEnter);
            // 
            // ganchezaDataGridViewTextBoxColumn
            // 
            this.ganchezaDataGridViewTextBoxColumn.DataPropertyName = "Gancheza";
            this.ganchezaDataGridViewTextBoxColumn.HeaderText = "Gancheza";
            this.ganchezaDataGridViewTextBoxColumn.Name = "ganchezaDataGridViewTextBoxColumn";
            // 
            // bdsWord
            // 
            this.bdsWord.DataSource = typeof(VocabularyEntities.Word);
            // 
            // pbNext
            // 
            this.pbNext.Image = global::ChineseVocabulary.Properties.Resources.Right;
            this.pbNext.Location = new System.Drawing.Point(670, 331);
            this.pbNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(50, 60);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 15;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbPrev
            // 
            this.pbPrev.Image = global::ChineseVocabulary.Properties.Resources.Left;
            this.pbPrev.Location = new System.Drawing.Point(240, 331);
            this.pbPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(53, 60);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrev.TabIndex = 14;
            this.pbPrev.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.PnadaW;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(579, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 649);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.uscWord);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TestStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudyForm";
            this.Text = "학습하기";
            this.Shown += new System.EventHandler(this.StudyForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TestStart;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbPrev;
        private Controls.WordControl uscWord;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganchezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsWord;
    }
}