﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocabularyEntities.Data;

namespace ChineseVocabulary.Controls
{
    public partial class UserProgressControl : UserControl
    {
        private bool _focused = false;
        public int Grade { get; set; }

        public UserProgressControl()
        {
            InitializeComponent();
        }

        public event EventHandler<ReSetClickEventArgs> ReSetClick;

        protected virtual void OnReSetClick()
        {
            ReSetClickEventArgs e = new ReSetClickEventArgs();
            e.Grade = Grade;

            ReSetClick(this, e);

        }

        public class ReSetClickEventArgs : System.EventArgs
        {
            public bool Reset { get; set; }
            public int Grade { get; set; }

            public ReSetClickEventArgs()
            { }

            public ReSetClickEventArgs(int grade)
            {
                Grade = grade;
            }

            public ReSetClickEventArgs(int grade, bool reset)
            {
                Grade = grade;
                Reset = reset;
            }
        }

        private void UserProgressControl_MouseEnter(object sender, EventArgs e)
        {
            if (!_focused)
                BackColor = Color.LightGoldenrodYellow;
        }

        private void UserProgressControl_MouseLeave(object sender, EventArgs e)
        {
            if (!_focused)
                BackColor = Color.White;
        }

        private void UserProgressControl_Enter(object sender, EventArgs e)
        {
            _focused = true;
            BackColor = Color.YellowGreen;
        }

        private void UserProgressControl_Leave(object sender, EventArgs e)
        {
            _focused = false;
            BackColor = Color.White;
        }

        private void UserProgressControl_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.MouseEnter += UserProgressControl_MouseEnter;
                control.MouseLeave += UserProgressControl_MouseLeave;
                control.Click += ChildControlClicked;
            }
        }

        private void ChildControlClicked(object sender, EventArgs e)
        {
            Select();
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            OnReSetClick();
        }
    }
}
