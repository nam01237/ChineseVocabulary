using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VocabularyEntities;
using VocabularyEntities.Data;

namespace ChineseVocabulary
{
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }

        private void btnSubmmit_Click(object sender, EventArgs e)
        {
            if (SignUpCheck())
            {
                User user = new User { Id = txtId.Text, PassWord = txtPw1.Text };
                DataRepository.Users.Insert(user);

                MessageBox.Show("회원가입 성공", "알림");

                Close();
            }
        }

        private bool SignUpCheck()
        {
            Regex regex = new Regex(@"^[a-z0-9_]{5,12}$");

            if ( txtId.Text.Equals("") )
            {
                MessageBox.Show("아이디를 입력해주세요", "알림");
                return false;
            }
            else if ( txtPw1.Text.Equals(""))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "알림");
                return false;
            }
            else if ( txtPw1.Text != txtPw2.Text )
            {
                MessageBox.Show("비밀번호가 서로 다릅니다.", "알림");
                return false;
            }

            if (regex.IsMatch(txtId.Text))
            {
                if (DataRepository.Users.GetByUserId(txtId.Text) != null)
                {
                    MessageBox.Show("중복된 아이디 입니다.", "알림");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("아이디는 영문대소문자, 숫자, 특수문자만 사용가능합니다.\n(5 ~ 12자)", "알림");
                return false;
            }




            return true;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
