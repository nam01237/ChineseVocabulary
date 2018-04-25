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
        }
    }
}
