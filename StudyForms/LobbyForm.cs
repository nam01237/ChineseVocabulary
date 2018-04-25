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
using VocabularyEntities;
using VocabularyEntities.Data;

namespace ChineseVocabulary
{
    public partial class LobbyForm : RootForm
    {
        private int _selectedGrade = 1;

        public LobbyForm()
        {
            InitializeComponent();
        }

        private void btnStuddy_Click(object sender, EventArgs e)
        {
            MemorizeForm studyForm = new MemorizeForm(_selectedGrade);
            studyForm.ModalParentForm = this;
            studyForm.ShowDialog();
            GradeControlSelect();

        }

        private void GradeSelected(object sender, EventArgs e)
        {
            _selectedGrade = ((UserProgressControl)sender).Grade;
        }

        private void GradeControlSelect()
        {
            foreach (Control control in Controls)
            {
                if (control is UserProgressControl)
                {
                    int grade = ((UserProgressControl)control).Grade;
                    if (grade == _selectedGrade)
                    {
                        control.Select();
                        break;
                    }
                }
            }
        }

        private void LobbyForm_Shown(object sender, EventArgs e)
        {

            ModalParentForm.Visible = false;

            foreach (Control control in Controls)
            {
                if (control is UserProgressControl)
                {
                    UserProgressControl upc = (UserProgressControl)control;

                    int grade = upc.Grade;
                    int totalCount = DataRepository.Words.GetCount(x => x.Grade == grade);
                    int memorizeCount = DataRepository.StagedWords.GetCount(x => x.UserKey == AccessUserKey && x.Word.Grade == grade);

                    upc.lblMemorize.Text = $" {memorizeCount} / {totalCount}";

                    upc.lblGrade.Text = $"{grade}급";
                    control.Enter += GradeSelected;
                }
            }

            GradeControlSelect();
            //userProgressControl1.Select();
        }
    }
}
