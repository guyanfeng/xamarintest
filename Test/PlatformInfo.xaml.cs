using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class PlatformInfo : ContentPage
    {
        public PlatformInfo()
        {
            InitializeComponent();

            var pi = DependencyService.Get<IPlatformInfo>();
            lblModel.Text = pi.GetModel();
            lblVersion.Text = pi.GetVersion();
        }
    }
}

