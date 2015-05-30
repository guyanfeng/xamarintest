using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test
{
    public class CountedLabel : Label
    {
        static readonly BindablePropertyKey WordCountKey = BindableProperty.CreateReadOnly("WordCount",
             typeof(int), typeof(CountedLabel), 0);
        public static readonly BindableProperty WordCountProperty = WordCountKey.BindableProperty;

        public int WordCount
        {
            get
            {
                return (int)GetValue(WordCountProperty);
            }
            private set
            {
                SetValue(WordCountKey, value);
            }
        }

        public CountedLabel()
        {
            PropertyChanged += CountedLabel_PropertyChanged;
        }

        void CountedLabel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Text")
            {
                if (string.IsNullOrEmpty(Text))
                {
                    WordCount = 0;
                }
                else
                {
                    WordCount = Text.Split(' ', '-', '\u2014').Length;
                }
            }
        }
    }
}
