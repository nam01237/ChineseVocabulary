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
            uscWord.LblWordProgress.Text = $"{bdsWord.Position + 1} / {_totalCount}";
        }

        private void AddWord()
        {
            bdsWord.Add(_testWords[_index]);
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

        }

    }
}
