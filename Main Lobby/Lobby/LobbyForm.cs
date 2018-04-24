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
    public partial class LobbyForm : RootForm
    {
        private int _selectedGrade;

        public LobbyForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
 

        private void btnStuddy_Click(object sender, EventArgs e)
        {
            ShowChild = true;
            ChildeForm = new StudyForm(_selectedGrade);
            Close();
        }

        private void LobbyForm_Shown(object sender, EventArgs e)
        {
            _selectedGrade = 1;

            foreach(Control control in Controls)
            {
                if( control is UserProgressControl)
                {

                }
            }
        }


    }
}
