using ChineseVocabulary.Controls;
using ChineseVocabulary.StudyForms;
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

namespace ChineseVocabulary.StudyForms
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
            CurrentGrade = _selectedGrade;
            MemorizeForm studyForm = new MemorizeForm();
            studyForm.StartLocation = Location;

            Visible = false;
            studyForm.ShowDialog();

            UpdateUserProgressControl();
            SelectGradeControl();
            Visible = true;
            SelectGradeControl();
        }

        private void GradeSelected(object sender, EventArgs e)
        {
            _selectedGrade = ((UserProgressControl)sender).Grade;
        }

        private void SelectGradeControl()
        {
            foreach (Control control in Controls)
            {
                if (control is UserProgressControl)
                {
                    int grade = ((UserProgressControl)control).Grade;
                    if (grade == CurrentGrade)
                    {
                        control.Select();
                        break;
                    }
                }
            }
        }

        private void LobbyForm_Shown(object sender, EventArgs e)
        {
            CloseParent = true;
            lblId.Text = AccessUSerId;

            UpdateUserProgressControl();

            CurrentGrade = 1;
            SelectGradeControl();
        }

        private void UpdateUserProgressControl()
        {

            foreach (Control control in Controls)
            {
                if (control is UserProgressControl)
                {
                    UserProgressControl upc = (UserProgressControl)control;
                    int grade = upc.Grade;
                    int totalCount = DataRepository.Words.GetCount(x => x.Grade == grade);
                    int memorizeCount = DataRepository.StagedWords.GetCount(x => x.UserKey == AccessUserKey && x.Word.Grade == grade && x.PassedCount >= 1);

                    upc.lblMemorize.Text = $"{memorizeCount} / {totalCount}";
                    upc.prbMemorize.Value = (int)((double)memorizeCount / totalCount * 100);
                    upc.lblGrade.Text = $"{grade}급";
                    upc.pbReset.Click += pbReset_Click;

                    control.Enter += GradeSelected;
                }
            }

        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 리셋하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRepository.StagedWords.DeleteWordByGrade(AccessUserKey, _selectedGrade);
                UpdateUserProgressControl();
            }
        }

        private void btnReStudy_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.StartLocation = Location;

            Visible = false;
            reviewForm.ShowDialog();

            UpdateUserProgressControl();
            SelectGradeControl();

            Visible = true;

        }

        private void userPicture_Click(object sender, EventArgs e)
        {
            CloseParent = false;
            Close();
        }
    }
}
