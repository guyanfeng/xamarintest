using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Test
{
    /// <summary>
    /// 自定义的解析 HSL 颜色的xaml 扩展标记
    /// </summary>
    public class HslColorExtension : IMarkupExtension
    {
        public HslColorExtension()
        {
            A = 1;
        }

        public double H
        {
            get;
            set;
        }

        public double S
        {
            get;
            set;
        }

        public double L
        {
            get;
            set;
        }

        public double A
        {
            get;
            set;
        }

        #region IMarkupExtension implementation

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromHsla(H, S, L, A);
        }

        #endregion
    }
}

