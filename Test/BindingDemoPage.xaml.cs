using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class BindingDemoPage : ContentPage
    {
        public BindingDemoPage()
        {
            InitializeComponent();
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            var obj = (Entry)sender;
            web_view.Source = obj.Text;
        }

        void OnBackClicked(object sender, EventArgs e)
        {
            web_view.GoBack();
        }

        void OnForwardClicked(object sender, EventArgs e)
        {
            web_view.GoForward();
        }
    }
}
