using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace Test
{
    public partial class ResourcePage : ContentPage
    {
        public ResourcePage()
        {
            InitializeComponent();
            var asm = GetType().GetTypeInfo().Assembly;
            var hasTitle = false;
            using (var stream = asm.GetManifestResourceStream("Test.TheBlackCat.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!hasTitle)
                        {
                            lblTitle.Text = line;
                            hasTitle = true;
                        }
                        else
                        {
                            var lbl = new Label()
                            {
                                Text = line,
                            };
                            palSub.Children.Add(lbl);
                        }
                    }
                }
            }
        }
    }
}

