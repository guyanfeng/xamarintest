using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class CheckBoxDemoPage : ContentPage
    {
        public CheckBoxDemoPage()
        {
            InitializeComponent();
        }

        void OnItalicCheckChanged(object sender, bool is_checked)
        {
            if (is_checked)
            {
                lbl.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                lbl.FontAttributes &= ~FontAttributes.Italic;
            }
        }

        void OnBoldCheckChanged(object sender, bool is_checked)
        {
            if (is_checked)
            {
                lbl.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                lbl.FontAttributes &= ~FontAttributes.Bold;
            }
        }
    }
}
