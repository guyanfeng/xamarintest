using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class XamlKeypad : ContentPage
    {
        App app = Application.Current as App;

        public XamlKeypad()
        {
            InitializeComponent();
            lblResult.Text = app.ResultText;
        }

        void OnNumericClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            lblResult.Text += btn.StyleId;
            btnBackspace.IsEnabled = true;
            app.ResultText = lblResult.Text;
        }

        void OnBackspaceClicked(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            btnBackspace.IsEnabled = lblResult.Text.Length > 0;
            app.ResultText = lblResult.Text;
        }
    }
}

