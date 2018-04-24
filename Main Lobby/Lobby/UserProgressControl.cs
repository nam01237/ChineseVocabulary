using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary.Main_Lobby
{
    public partial class UserProgressControl : UserControl
    {
        private bool _focused = false;
        public int Grade { get; set; } 

        public UserProgressControl()
        {
            InitializeComponent();
        }

        //private void UserProgressControl_MouseEnter(object sender, EventArgs e)
        //{
        //    if ( !_focused )
        //        BackColor =  Color.Azure;
        //}

        //private void UserProgressControl_MouseLeave(object sender, EventArgs e)
        //{
        //    if ( !_focused)
        //        BackColor = Color.White;
        //}

        //private void UserProgressControl_Enter(object sender, EventArgs e)
        //{
        //    _focused = true;
        //    BackColor = Color.DeepSkyBlue;
        //}

        //private void UserProgressControl_Leave(object sender, EventArgs e)
        //{
        //    _focused = false;
        //    BackColor = Color.White;
        //}
        
    }
}
