using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class TwoButtonPage : ContentPage
    {
        public TwoButtonPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == btnAdd)
            {
                var lbl = new Label()
                {
                    Text = "Button clicked at:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    HorizontalOptions = LayoutOptions.Center
                };
                pal.Children.Add(lbl);
            }
            else if (sender == btnRemove)
            {
                pal.Children.RemoveAt(0);
            }
            btnRemove.IsEnabled = pal.Children.Count > 0;
        }
    }
}