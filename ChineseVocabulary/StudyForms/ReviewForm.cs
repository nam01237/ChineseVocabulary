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
    public partial class ReviewForm : TestForm
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        protected override void SetWordList()
        {
            _testWords = DataRepository.Words.GetReviewList(AccessUserKey); 
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            InitForm();
            dgvWords.CellEnter += SetPassedCount;
        }

        private void SetPassedCount(object sender, EventArgs e)
        {
            Word word = bdsWord.Current as Word;
            lblPassedCount.Text = $"{word.PassedCount}번 맞춘 단어";
        }
    }
}
