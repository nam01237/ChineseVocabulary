namespace ChineseVocabulary
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TestStart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnReveal = new System.Windows.Forms.Button();
            this.wordControl1 = new ChineseVocabulary.Controls.WordControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStagedWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
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
            this.dgvWords.Location = new System.Drawing.Point(16, 72);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWords.RowTemplate.Height = 23;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(188, 391);
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
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 64);
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
            this.TestStart.Text = "돌아가기";
            this.TestStart.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandagreen;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(528, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 57);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandared;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(265, 441);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 57);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(453, 447);
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
            this.btnNo.Location = new System.Drawing.Point(326, 447);
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
            this.btnReveal.Location = new System.Drawing.Point(591, 354);
            this.btnReveal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(28, 31);
            this.btnReveal.TabIndex = 33;
            this.btnReveal.Text = "답";
            this.btnReveal.UseVisualStyleBackColor = false;
            // 
            // wordControl1
            // 
            this.wordControl1.BackColor = System.Drawing.Color.White;
            this.wordControl1.Location = new System.Drawing.Point(251, 96);
            this.wordControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordControl1.Name = "wordControl1";
            this.wordControl1.Size = new System.Drawing.Size(346, 340);
            this.wordControl1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 64);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(130, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 64);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(194, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 64);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(258, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(58, 64);
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(322, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 64);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(386, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 64);
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(451, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(58, 64);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(579, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(58, 64);
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(515, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(58, 64);
            this.pictureBox12.TabIndex = 19;
            this.pictureBox12.TabStop = false;
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
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsStagedWords;
        private Controls.WordControl wordControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button TestStart;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}