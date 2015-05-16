using System;
using Android.OS;
using Xamarin.Forms;

[assembly:Dependency(typeof(Test.Droid.PlatformInfo))]
namespace Test.Droid
{
    public class PlatformInfo : IPlatformInfo
    {
        public PlatformInfo()
        {
        }

        #region IPlatformInfo implementation

        public string GetModel()
        {
            return string.Format("{0} {1}", Build.Manufacturer, Build.Model);
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }

        #endregion
    }
}

