using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class WordCountPage : ContentPage
    {
        public WordCountPage()
        {
            InitializeComponent();
            lblCounter.Text = string.Format("{0} words", lblText.WordCount);
        }
    }
}
