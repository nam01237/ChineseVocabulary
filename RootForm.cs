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
        public static int AccessUserKey { get; set; }
        public static string AccessUSerId { get; set; }
        public RootForm ModalParentForm { get; set; }

        protected RootForm()
        {
            InitializeComponent();
        }
    }
}
