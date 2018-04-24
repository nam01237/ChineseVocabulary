using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChineseVocabulary.Main_Lobby;

namespace ChineseVocabulary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            JoinForm joinForm = new JoinForm();
            joinForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            LobbyForm lobbyForm = new LobbyForm();
            lobbyForm.ShowDialog();

           
        }
    }
}
