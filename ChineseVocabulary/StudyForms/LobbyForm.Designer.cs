using ChineseVocabulary.Controls;
using ChineseVocabulary.Main_Lobby;

namespace ChineseVocabulary.StudyForms
{
    partial class LobbyForm
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
            this.btnStuddy = new System.Windows.Forms.Button();
            this.btnReStudy = new System.Windows.Forms.Button();
            this.userProgressControl1 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userProgressControl2 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userProgressControl3 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userProgressControl4 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userProgressControl5 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userProgressControl6 = new ChineseVocabulary.Controls.UserProgressControl();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStuddy
            // 
            this.btnStuddy.BackColor = System.Drawing.Color.White;
            this.btnStuddy.Location = new System.Drawing.Point(491, 443);
            this.btnStuddy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStuddy.Name = "btnStuddy";
            this.btnStuddy.Size = new System.Drawing.Size(84, 45);
            this.btnStuddy.TabIndex = 0;
            this.btnStuddy.Text = "학습하기";
            this.btnStuddy.UseVisualStyleBackColor = false;
            this.btnStuddy.Click += new System.EventHandler(this.btnStuddy_Click);
            // 
            // btnReStudy
            // 
            this.btnReStudy.BackColor = System.Drawing.Color.White;
            this.btnReStudy.Location = new System.Drawing.Point(401, 443);
            this.btnReStudy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReStudy.Name = "btnReStudy";
            this.btnReStudy.Size = new System.Drawing.Size(84, 45);
            this.btnReStudy.TabIndex = 1;
            this.btnReStudy.Text = "복습하기";
            this.btnReStudy.UseVisualStyleBackColor = false;
            this.btnReStudy.Click += new System.EventHandler(this.btnReStudy_Click);
            // 
            // userProgressControl1
            // 
            this.userProgressControl1.BackColor = System.Drawing.Color.White;
            this.userProgressControl1.Grade = 1;
            this.userProgressControl1.Location = new System.Drawing.Point(36, 94);
            this.userProgressControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl1.Name = "userProgressControl1";
            this.userProgressControl1.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl1.TabIndex = 18;
            // 
            // userProgressControl2
            // 
            this.userProgressControl2.BackColor = System.Drawing.Color.White;
            this.userProgressControl2.Grade = 2;
            this.userProgressControl2.Location = new System.Drawing.Point(36, 152);
            this.userProgressControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl2.Name = "userProgressControl2";
            this.userProgressControl2.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl2.TabIndex = 18;
            // 
            // userProgressControl3
            // 
            this.userProgressControl3.BackColor = System.Drawing.Color.White;
            this.userProgressControl3.Grade = 3;
            this.userProgressControl3.Location = new System.Drawing.Point(36, 210);
            this.userProgressControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl3.Name = "userProgressControl3";
            this.userProgressControl3.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl3.TabIndex = 18;
            // 
            // userProgressControl4
            // 
            this.userProgressControl4.BackColor = System.Drawing.Color.White;
            this.userProgressControl4.Grade = 4;
            this.userProgressControl4.Location = new System.Drawing.Point(36, 268);
            this.userProgressControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl4.Name = "userProgressControl4";
            this.userProgressControl4.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl4.TabIndex = 18;
            // 
            // userProgressControl5
            // 
            this.userProgressControl5.BackColor = System.Drawing.Color.White;
            this.userProgressControl5.Grade = 5;
            this.userProgressControl5.Location = new System.Drawing.Point(36, 326);
            this.userProgressControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl5.Name = "userProgressControl5";
            this.userProgressControl5.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl5.TabIndex = 18;
            // 
            // userProgressControl6
            // 
            this.userProgressControl6.BackColor = System.Drawing.Color.White;
            this.userProgressControl6.Grade = 6;
            this.userProgressControl6.Location = new System.Drawing.Point(36, 384);
            this.userProgressControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userProgressControl6.Name = "userProgressControl6";
            this.userProgressControl6.Size = new System.Drawing.Size(564, 45);
            this.userProgressControl6.TabIndex = 18;
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = global::ChineseVocabulary.Properties.Resources.pandewhite;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPicture.Location = new System.Drawing.Point(48, 11);
            this.userPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(70, 60);
            this.userPicture.TabIndex = 20;
            this.userPicture.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gulim", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.Location = new System.Drawing.Point(124, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(103, 30);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "사용자";
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 520);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.userProgressControl6);
            this.Controls.Add(this.userProgressControl5);
            this.Controls.Add(this.userProgressControl4);
            this.Controls.Add(this.userProgressControl3);
            this.Controls.Add(this.userProgressControl2);
            this.Controls.Add(this.userProgressControl1);
            this.Controls.Add(this.btnReStudy);
            this.Controls.Add(this.btnStuddy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LobbyForm";
            this.Text = "중국어 학습";
            this.Shown += new System.EventHandler(this.LobbyForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStuddy;
        private System.Windows.Forms.Button btnReStudy;
        private UserProgressControl userProgressControl1;
        private UserProgressControl userProgressControl2;
        private UserProgressControl userProgressControl3;
        private UserProgressControl userProgressControl4;
        private UserProgressControl userProgressControl5;
        private UserProgressControl userProgressControl6;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label lblId;
    }
}