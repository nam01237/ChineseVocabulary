using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseVocabulary.Controls
{
    public class GradeSelectButton : Button
    {
        public int Grade { get; set; }

        protected override void OnClick(EventArgs e)
        {
            OnGradeButtonClicked(new GradeButtonClickedEventArgs(Grade));
        }

        #region GradeButtonClicked event things for C# 3.0
        public event EventHandler<GradeButtonClickedEventArgs> GradeButtonClicked;

        protected virtual void OnGradeButtonClicked(GradeButtonClickedEventArgs e)
        {
            if (GradeButtonClicked != null)
                GradeButtonClicked(this, e);
        }


        #endregion
    }

    public class GradeButtonClickedEventArgs : EventArgs
    {
        public int Geade { get; set; }

        public GradeButtonClickedEventArgs()
        {
        }

        public GradeButtonClickedEventArgs(int geade)
        {
            Geade = geade;
        }
    }
}
