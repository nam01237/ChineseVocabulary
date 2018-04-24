using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocabularyEntities;
using VocabularyEntities.Data;

namespace ChineseVocabulary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JoinForm joinForm = new JoinForm();
            joinForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Text;

            if( id.Equals("") || pw.Equals("") )
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "알림");
                return;
            }

            User user = DataRepository.Users.GetByUserId(id);

            if (user == null)
            {
                MessageBox.Show("없는 아이디 입니다.", "알림");
                return;
            }
            else
            {
                if( user.PassWord.Equals(pw) )
                {
                    
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀립니다.", "알림");
                    return;
                }
            }
            
        }

    }
}
