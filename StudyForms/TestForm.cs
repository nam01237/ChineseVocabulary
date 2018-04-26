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
        protected List<Word> _testWords;
        protected int _index;
        protected int _totalCount;
        protected bool _finished;

        public TestForm()
        {
            InitializeComponent();
        }

        protected virtual void SetWordList()
        { }

        protected void InitForm()
        {
            CloseParent = true;
            _finished = false;
            _index = 0;
            _totalCount = _testWords.Count;
            Location = StartLocation;
            AddWord();

        }

        protected void UpdateWordControl()
        {
            Word word = bdsWord.Current as Word;
            uscWord.lblWord.Text = word.Gancheza;
            uscWord.lblByeongEum.Text = word.ByeongEum;
            uscWord.lblWordClass.Text = word.WordClass;
            uscWord.lblMeaning.Text = "";
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_totalCount}";
        }

        protected void AddWord()
        {
            bdsWord.Add(_testWords[_index]);
            bdsWord.MoveNext();
            _index++;
        }

        protected void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateWordControl();
        }

        protected void CorrectWord()
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
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            CorrectWord();
            AddWord();
        }

        protected void WrongWord()
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

        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            WrongWord();
            AddWord();
        }

        protected void TestStart_Click(object sender, EventArgs e)
        {
            CloseParent = false;
            Close();
        }

        protected void btnReveal_Click(object sender, EventArgs e)
        {
            Word word = bdsWord.Current as Word;
            uscWord.lblMeaning.Text = word.Meaning;
        }
    }
}
