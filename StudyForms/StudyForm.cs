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
    public partial class StudyForm : RootForm
    {
        private int _currentGrade;
        private int _gradeCount;

        public StudyForm()
        {
            InitializeComponent();
        }

        public StudyForm(int grade) : this()
        {
            _currentGrade = grade;
        }

        private void StudyForm_Shown(object sender, EventArgs e)
        {
            _gradeCount = DataRepository.Words.GetCount(x => x.Grade == _currentGrade);
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
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (bdsWord.Position == bdsWord.Count - 1 && bdsWord.Position < bdsWord.Count - 1)
            {
                Word currentWord = bdsWord.Current as Word;
                Word nextWord = DataRepository.Words.GetNetxWord(currentWord, AccessUserKey);
                bdsWord.Add(nextWord);

                StagedWord stagedWord =
                    new StagedWord
                    {
                        UserKey = AccessUserKey,
                        WordId = nextWord.WordId,
                    };

                DataRepository.StagedWords.Insert(stagedWord);
                return;
            }

            bdsWord.MoveNext();
            
        }

        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Word word = bdsWord.Current as Word;
            uscWord.txtWord.Text = word.Gancheza;
            uscWord.txtMeaning.Text = word.Meaning;
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_gradeCount}";
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            bdsWord.MovePrevious();
        }
    }
}
