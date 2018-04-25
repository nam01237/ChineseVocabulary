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
            this.components = new System.ComponentModel.Container();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.wordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsStagedWords = new System.Windows.Forms.BindingSource(this.components);
            this.wordControl1 = new ChineseVocabulary.Controls.WordControl();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TestStart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStagedWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.dgvWords.Location = new System.Drawing.Point(17, 71);
            this.dgvWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowTemplate.Height = 27;
            this.dgvWords.Size = new System.Drawing.Size(187, 393);
            this.dgvWords.TabIndex = 17;
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
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.White;
            this.wordControl1.Location = new System.Drawing.Point(251, 109);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.Size = new System.Drawing.Size(346, 340);
            this.wordControl1.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Gulim", 13F);
            this.button6.Location = new System.Drawing.Point(296, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 42);
            this.button6.TabIndex = 25;
            this.button6.Text = "6급";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Gulim", 13F);
            this.button5.Location = new System.Drawing.Point(240, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 42);
            this.button5.TabIndex = 24;
            this.button5.Text = "5급";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Gulim", 13F);
            this.button4.Location = new System.Drawing.Point(184, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 42);
            this.button4.TabIndex = 23;
            this.button4.Text = "4급";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Gulim", 13F);
            this.button3.Location = new System.Drawing.Point(128, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 42);
            this.button3.TabIndex = 22;
            this.button3.Text = "3급";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Gulim", 13F);
            this.button2.Location = new System.Drawing.Point(72, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "2급";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Gulim", 13F);
            this.button1.Location = new System.Drawing.Point(16, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "1급";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(507, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 102);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // TestStart
            // 
            this.TestStart.Font = new System.Drawing.Font("Gulim", 12F);
            this.TestStart.Location = new System.Drawing.Point(16, 468);
            this.TestStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(188, 39);
            this.TestStart.TabIndex = 18;
            this.TestStart.Text = "시험보기";
            this.TestStart.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandagreen;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(531, 450);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 57);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandared;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(269, 450);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 57);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(456, 456);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(69, 42);
            this.btnYes.TabIndex = 30;
            this.btnYes.Text = "알겠어요";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(330, 456);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 42);
            this.btnNo.TabIndex = 29;
            this.btnNo.Text = "모르겠어요";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // btnReveal
            // 
            this.btnReveal.BackColor = System.Drawing.Color.White;
            this.btnReveal.Font = new System.Drawing.Font("Gulim", 12F);
            this.btnReveal.Location = new System.Drawing.Point(591, 370);
            this.btnReveal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(28, 31);
            this.btnReveal.TabIndex = 33;
            this.btnReveal.Text = "답";
            this.btnReveal.UseVisualStyleBackColor = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 519);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.wordControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TestStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStagedWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsStagedWords;
        private Controls.WordControl wordControl1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button TestStart;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnReveal;
    }
}