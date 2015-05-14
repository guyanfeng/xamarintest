using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class ButtonClickPage : ContentPage
    {
        public ButtonClickPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            var lbl = new Label()
            {
                Text = "Button clicked at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                HorizontalOptions = LayoutOptions.Center,
            };
            pal.Children.Add(lbl);
        }
    }
}

