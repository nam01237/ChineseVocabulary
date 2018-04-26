using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary
{
    public partial class RootForm : Form
    {
        protected static int AccessUserKey { get; set; }
        protected static string AccessUSerId { get; set; }
        protected static int CurrentGrade { get; set; }
        public bool CloseParent { get; set; }
        public Point StartLocation { get; set; }

        protected RootForm()
        {
            CloseParent = false;
            InitializeComponent();
        }

    }


}
