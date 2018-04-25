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

        public StudyForm(int grade)
        {
            _currentGrade = grade;
            InitializeComponent();
        }


        private void StudyForm_Shown(object sender, EventArgs e)
        {
            UpdateWordList();
        }

        private void UpdateWordList()
        {
            List<Word> words = DataRepository.StagedWords.GetByGrade(AccessUserKey, _currentGrade);
            bdsWord.DataSource = words;
            bdsWord.MoveLast();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if( bdsWord.Position == bdsWord.Count - 1)
            {

            }

            bdsWord.MoveNext();
        }

        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Word word = bdsWord.Current as Word;
            uscWord.txtWord.Text = word.Gancheza;
        }
    }
}
