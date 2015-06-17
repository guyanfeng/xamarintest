using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class ToolbarPage : ContentPage
    {
        public ToolbarPage()
        {
            InitializeComponent();
        }

        void OnToolbarItemClicked(object sender, EventArgs e)
        {
            var tb = (ToolbarItem)sender;
            lbl.Text = "Toolbar " + tb.Text + " clicked";
        }
    }
}
