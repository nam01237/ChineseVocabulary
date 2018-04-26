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
        private int _gradeCount;

        public MemorizeForm()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            _gradeCount = DataRepository.Words.GetCount(x => x.Grade == CurrentGrade);
            Location = StartLocation;

            foreach (Control control in Controls)
            {
                if (control is GradeSelectButton)
                    control.Click += btnGrade_Click;
            }

            UpdateWordList();
        }

        private void UpdateWordList()
        {
            List<Word> words = DataRepository.Words.GetByGrade(AccessUserKey, CurrentGrade);

            if( words.Count == 0)
            {
                words = new List<Word>();
                Word firstWord = DataRepository.Words.GetFirst(x => x.Grade == CurrentGrade);
                words.Add(firstWord);

                StagedWord stagedWord = new StagedWord
                {
                    UserKey = AccessUserKey,
                    WordId = firstWord.WordId,
                };

                DataRepository.StagedWords.Insert(stagedWord);
            }

            uscWord.lblGrade.Text = $"{CurrentGrade} 급";
            bdsWord.DataSource = words;
            bdsWord.Position = bdsWord.Count - 1;

            foreach (var item in bdsWord)
            {
                Word word = (Word)item;
                
                if( word.PassedCount == 0 )
                {
                    int index = bdsWord.IndexOf(word);
                    dgvWords.Rows[index].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void MoveNextWord()
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

        private void UpdateWordControl()
        {
            Word word = bdsWord.Current as Word;
            uscWord.lblWord.Text = word.Gancheza;
            uscWord.lblMeaning.Text = word.Meaning;
            uscWord.lblByeongEum.Text = word.ByeongEum;
            uscWord.lblWordClass.Text = word.WordClass;
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_gradeCount}";
        }

        private void StudyForm_Shown(object sender, EventArgs e)
        {
            InitForm();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            MoveNextWord();
        }

        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateWordControl();
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            bdsWord.MovePrevious();
        }

        private void pbRetuen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            CurrentGrade = ((GradeSelectButton)sender).Grade;
            UpdateWordList();

        }

        private void TestStart_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.StartLocation = Location;

            Visible = false;
            testForm.ShowDialog();

            if (testForm.CloseParent)
                Close();

            UpdateWordList();
            Visible = true;
        }
    }
}
