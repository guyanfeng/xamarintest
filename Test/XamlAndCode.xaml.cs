using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class XamlAndCode : ContentPage
    {
        public XamlAndCode()
        {
            InitializeComponent();

            var lbl = new Label()
            {
                Text = "Label From Code",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Blue,
                BackgroundColor = Color.FromRgb(255, 128, 128),
                Opacity = 0.75
            };
            pal.Children.Insert(0, lbl);
        }
    }
}

