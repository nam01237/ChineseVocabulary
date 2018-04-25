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
using ChineseVocabulary.Controls;

namespace ChineseVocabulary
{
    public partial class MemorizeForm : RootForm
    {
        private int _currentGrade;
        private int _gradeCount;

        public MemorizeForm()
        {
            InitializeComponent();
        }

        public MemorizeForm(int grade) : this()
        {
            _currentGrade = grade;
        }

        private void StudyForm_Shown(object sender, EventArgs e)
        {
            _gradeCount = DataRepository.Words.GetCount(x => x.Grade == _currentGrade);

            foreach (Control control in Controls)
            {
                if (control is GradeSelectButton)
                    ((GradeSelectButton)control).GradeButtonClicked += btnGrade_Click;
            }

            UpdateWordList();
        }

        private void UpdateWordList()
        {
            List<Word> words = DataRepository.StagedWords.GetByGrade(AccessUserKey, _currentGrade);

            if( words.Count == 0)
            {
                words = new List<Word>();
                words.Add(DataRepository.Words.GetFirst( x => x.Grade == _currentGrade  ));
            }

            uscWord.lblGrade.Text = $"{_currentGrade} 급";
            bdsWord.DataSource = words;
            bdsWord.Position = bdsWord.Count - 1;

            foreach (var item in bdsWord)
            {
                Word word = (Word)item;
                
                if( !word.Tested)
                {
                    int index = bdsWord.IndexOf(word);
                    dgvWords.Rows[index].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (bdsWord.Position == bdsWord.Count - 1 && bdsWord.Position < _gradeCount - 1)
            {
                Word currentWord = bdsWord.Current as Word;
                Word nextWord = DataRepository.Words.GetNetxWord(currentWord, AccessUserKey);
                bdsWord.Add(nextWord);
                dgvWords.CurrentRow.DefaultCellStyle.BackColor = Color.Pink;

                StagedWord stagedWord =
                    new StagedWord
                    {
                        UserKey = AccessUserKey,
                        WordId = nextWord.WordId,
                    };

                DataRepository.StagedWords.Insert(stagedWord);
            }
            
            bdsWord.MoveNext();
            
        }

        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Word word = bdsWord.Current as Word;
            uscWord.txtWord.Text = word.Gancheza;
            uscWord.txtMeaning.Text = word.Meaning;
            uscWord.txtByeongEum.Text = word.ByeongEum;
            uscWord.txtWordClass.Text = word.WordClass;
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_gradeCount}";
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            bdsWord.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            _currentGrade = ((GradeButtonClickedEventArgs)e).Geade;
            UpdateWordList();

        }

        private void TestStart_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.ModalParentForm = this;
            testForm.ShowDialog();
        }
    }
}
