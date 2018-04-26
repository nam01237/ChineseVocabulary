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
    public partial class TestForm : RootForm
    {
        private List<Word> _testWords;
        private int _index;
        private int _totalCount;
        private bool _finished;

        public TestForm()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            CloseParent = true;
            _finished = false;
            _index = 0;
            _testWords = DataRepository.Words.GetTestList(AccessUserKey, CurrentGrade);
            _totalCount = _testWords.Count;
            Location = StartLocation;
            AddWord();

        }

        private void UpdateWordControl()
        {
            Word word = bdsWord.Current as Word;
            uscWord.txtWord.Text = word.Gancheza;
            uscWord.txtByeongEum.Text = word.ByeongEum;
            uscWord.txtWordClass.Text = word.WordClass;
            uscWord.txtMeaning.Text = "";
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_totalCount}";
        }

        private void AddWord()
        {
            bdsWord.Add(_testWords[_index]);
            bdsWord.MoveNext();
            _index++;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            InitForm();
        }


        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateWordControl();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            dgvWords.CurrentRow.DefaultCellStyle.BackColor = Color.GreenYellow;
            int wordId = ((Word)bdsWord.Current).WordId;
            int passedCount = DataRepository.StagedWords.IncreasePassedCount(AccessUserKey, wordId);
            DataRepository.Histiries.Insert(
                new History
                {
                    Pass = true,
                    UserKey = AccessUserKey,
                    WordId = wordId,
                    IncreasedTo = passedCount,
                    At = DateTime.Now
                });
            AddWord();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            dgvWords.CurrentRow.DefaultCellStyle.BackColor = Color.Pink;
            int wordId = ((Word)bdsWord.Current).WordId;

            DataRepository.Histiries.Insert(
                new History
                {
                    Pass = false,
                    UserKey = AccessUserKey,
                    WordId = wordId,
                    IncreasedTo = 0,
                    At = DateTime.Now
                });
            AddWord();
        }

        private void TestStart_Click(object sender, EventArgs e)
        {
            CloseParent = false;
            Close();
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            Word word = bdsWord.Current as Word;
            uscWord.txtMeaning.Text = word.Meaning;
        }
    }
}
