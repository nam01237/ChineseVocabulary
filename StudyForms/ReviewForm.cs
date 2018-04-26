using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            _testWords = DataRepository.Words.GetTestList(AccessUserKey); 
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
