using ChineseVocabulary.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary
{
    public partial class LobbyForm : RootForm
    {
        private int _selectedGrade = 1;

        public LobbyForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
 

        private void btnStuddy_Click(object sender, EventArgs e)
        {
            StudyForm studyForm = new StudyForm(_selectedGrade);
            studyForm.ModalParentForm = this;
            studyForm.ShowDialog();
        }

        private void LobbyForm_Load(object sender, EventArgs e)
        {
            ModalParentForm.Visible = false;

            foreach (Control control in Controls)
            {
                if (control is UserProgressControl)
                {
                    int grade = ((UserProgressControl)control).Grade;
                    ((UserProgressControl)control).lblGrade.Text = $"{grade}급";
                    control.Enter += GradeSelected;
                }
            }

            userProgressControl1.Select();
        }

        private void GradeSelected(object sender, EventArgs e)
        {
            _selectedGrade = ((UserProgressControl)sender).Grade;
        }
    }
}
