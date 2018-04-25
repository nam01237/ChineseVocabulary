using ChineseVocabulary.Controls;

namespace ChineseVocabulary
{
    partial class MemorizeForm
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
            this.btnGrade6 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.btnGrade5 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.btnGrade4 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.btnGrade3 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.btnGrade2 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.btnGrade1 = new ChineseVocabulary.Controls.GradeSelectButton();
            this.uscWord = new ChineseVocabulary.Controls.WordControl();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.ganchezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByeongEum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TestStart.Location = new System.Drawing.Point(16, 468);
            this.TestStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestStart.Name = "TestStart";
            this.TestStart.Size = new System.Drawing.Size(188, 39);
            this.TestStart.TabIndex = 1;
            this.TestStart.Text = "시험보기";
            this.TestStart.UseVisualStyleBackColor = false;
            this.TestStart.Click += new System.EventHandler(this.TestStart_Click);
            // 
            // btnGrade6
            // 
            this.btnGrade6.BackColor = System.Drawing.Color.White;
            this.btnGrade6.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade6.Grade = 6;
            this.btnGrade6.Location = new System.Drawing.Point(296, 11);
            this.btnGrade6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade6.Name = "btnGrade6";
            this.btnGrade6.Size = new System.Drawing.Size(51, 42);
            this.btnGrade6.TabIndex = 13;
            this.btnGrade6.Text = "6급";
            this.btnGrade6.UseVisualStyleBackColor = false;
            // 
            // btnGrade5
            // 
            this.btnGrade5.BackColor = System.Drawing.Color.White;
            this.btnGrade5.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade5.Grade = 5;
            this.btnGrade5.Location = new System.Drawing.Point(240, 11);
            this.btnGrade5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade5.Name = "btnGrade5";
            this.btnGrade5.Size = new System.Drawing.Size(51, 42);
            this.btnGrade5.TabIndex = 12;
            this.btnGrade5.Text = "5급";
            this.btnGrade5.UseVisualStyleBackColor = false;
            // 
            // btnGrade4
            // 
            this.btnGrade4.BackColor = System.Drawing.Color.White;
            this.btnGrade4.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade4.Grade = 4;
            this.btnGrade4.Location = new System.Drawing.Point(184, 11);
            this.btnGrade4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade4.Name = "btnGrade4";
            this.btnGrade4.Size = new System.Drawing.Size(51, 42);
            this.btnGrade4.TabIndex = 11;
            this.btnGrade4.Text = "4급";
            this.btnGrade4.UseVisualStyleBackColor = false;
            // 
            // btnGrade3
            // 
            this.btnGrade3.BackColor = System.Drawing.Color.White;
            this.btnGrade3.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade3.Grade = 3;
            this.btnGrade3.Location = new System.Drawing.Point(128, 11);
            this.btnGrade3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade3.Name = "btnGrade3";
            this.btnGrade3.Size = new System.Drawing.Size(51, 42);
            this.btnGrade3.TabIndex = 10;
            this.btnGrade3.Text = "3급";
            this.btnGrade3.UseVisualStyleBackColor = false;
            // 
            // btnGrade2
            // 
            this.btnGrade2.BackColor = System.Drawing.Color.White;
            this.btnGrade2.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade2.Grade = 2;
            this.btnGrade2.Location = new System.Drawing.Point(72, 11);
            this.btnGrade2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade2.Name = "btnGrade2";
            this.btnGrade2.Size = new System.Drawing.Size(51, 42);
            this.btnGrade2.TabIndex = 9;
            this.btnGrade2.Text = "2급";
            this.btnGrade2.UseVisualStyleBackColor = false;
            // 
            // btnGrade1
            // 
            this.btnGrade1.BackColor = System.Drawing.Color.White;
            this.btnGrade1.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnGrade1.Grade = 1;
            this.btnGrade1.Location = new System.Drawing.Point(16, 11);
            this.btnGrade1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade1.Name = "btnGrade1";
            this.btnGrade1.Size = new System.Drawing.Size(51, 42);
            this.btnGrade1.TabIndex = 8;
            this.btnGrade1.Text = "1급";
            this.btnGrade1.UseVisualStyleBackColor = false;
            // 
            // uscWord
            // 
            this.uscWord.BackColor = System.Drawing.Color.White;
            this.uscWord.Location = new System.Drawing.Point(248, 124);
            this.uscWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscWord.Name = "uscWord";
            this.uscWord.Size = new System.Drawing.Size(346, 340);
            this.uscWord.TabIndex = 16;
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToResizeColumns = false;
            this.dgvWords.AllowUserToResizeRows = false;
            this.dgvWords.AutoGenerateColumns = false;
            this.dgvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWords.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWords.ColumnHeadersVisible = false;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganchezaDataGridViewTextBoxColumn,
            this.ByeongEum});
            this.dgvWords.DataSource = this.bdsWord;
            this.dgvWords.Location = new System.Drawing.Point(16, 72);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWords.RowTemplate.Height = 23;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(188, 391);
            this.dgvWords.TabIndex = 17;
            this.dgvWords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellEnter);
            // 
            // ganchezaDataGridViewTextBoxColumn
            // 
            this.ganchezaDataGridViewTextBoxColumn.DataPropertyName = "Gancheza";
            this.ganchezaDataGridViewTextBoxColumn.HeaderText = "Gancheza";
            this.ganchezaDataGridViewTextBoxColumn.Name = "ganchezaDataGridViewTextBoxColumn";
            // 
            // ByeongEum
            // 
            this.ByeongEum.DataPropertyName = "ByeongEum";
            this.ByeongEum.HeaderText = "ByeongEum";
            this.ByeongEum.Name = "ByeongEum";
            // 
            // bdsWord
            // 
            this.bdsWord.DataSource = typeof(VocabularyEntities.Word);
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
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.PnadaW;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(507, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 102);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MemorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 519);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.uscWord);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.btnGrade6);
            this.Controls.Add(this.btnGrade5);
            this.Controls.Add(this.btnGrade4);
            this.Controls.Add(this.btnGrade3);
            this.Controls.Add(this.btnGrade2);
            this.Controls.Add(this.btnGrade1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TestStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MemorizeForm";
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
        private GradeSelectButton btnGrade6;
        private GradeSelectButton btnGrade5;
        private GradeSelectButton btnGrade4;
        private GradeSelectButton btnGrade3;
        private GradeSelectButton btnGrade2;
        private GradeSelectButton btnGrade1;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbPrev;
        private Controls.WordControl uscWord;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.BindingSource bdsWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganchezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByeongEum;
    }
}