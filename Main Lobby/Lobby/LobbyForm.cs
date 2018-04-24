using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary.Main_Lobby
{
    public partial class LobbyForm : Form
    {
        
        public LobbyForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
 

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            int btnClick;
            btnClick = 0;

            btnLevel1.Enabled = true;
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnLevel4.Enabled = false;
            btnLevel5.Enabled = false;
            btnLevel6.Enabled = false;
            
            btnClick++;

            if (btnClick == 2)
            {
                btnLevel1.Enabled = true;
                btnLevel2.Enabled = true;
                btnLevel3.Enabled = true;
                btnLevel4.Enabled = true;
                btnLevel5.Enabled = true;
                btnLevel6.Enabled = true;
            }


        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel2.Enabled = true;
            btnLevel3.Enabled = false;
            btnLevel4.Enabled = false;
            btnLevel5.Enabled = false;
            btnLevel6.Enabled = false;


        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = true;
            btnLevel4.Enabled = false;
            btnLevel5.Enabled = false;
            btnLevel6.Enabled = false;


        }

        private void btnLevel4_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnLevel4.Enabled = true;
            btnLevel5.Enabled = false;
            btnLevel6.Enabled = false;


        }

        private void btnLevel5_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnLevel4.Enabled = false;
            btnLevel5.Enabled = true;
            btnLevel6.Enabled = false;


        }

        private void btnLevel6_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnLevel4.Enabled = false;
            btnLevel5.Enabled = false;
            btnLevel6.Enabled = true;


        }

    }
}
