using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary
{
    public partial class RootForm : Form
    {
        public static string AccessId { get; set; }
        public RootForm ChildeForm { get; set; } 
        public bool ShowChild { get; set; }

        protected RootForm()
        {
            ShowChild = false;
            InitializeComponent();
        }
    }
}
