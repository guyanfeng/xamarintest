using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class XamlTimer : ContentPage
    {
        public XamlTimer()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    lblTmr.Text = DateTime.Now.ToString("T");
                    lblDate.Text = DateTime.Now.ToString("D");
                    return true;
                });
        }
    }
}

