using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary.Main_Lobby
{
    public partial class StudyForm : RootForm
    {
        private int _currentGrade;

        public StudyForm(int grade)
        {
            _currentGrade = grade;
            InitializeComponent();
        }

        private void testControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
