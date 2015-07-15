using System;
using System.Collections.Generic;
using System.ComponentModel;

//using System.Net;
using System.Runtime.Serialization;
using Xamarin.Forms;

namespace Test
{
    public partial class ImageBrowserPage : ContentPage
    {
        /*WebRequest web_req;
        ImageList image_list;
        int image_index;

        public ImageBrowserPage()
        {
            InitializeComponent();
            Uri uri = new Uri("http://docs.xamarin.com/demo/stock.json");
            web_req = WebRequest.Create(uri);
            web_req.BeginGetResponse(WebRequestCallback, null);
        }

        void WebRequestCallback(IAsyncResult async_result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    var stream = web_req.EndGetResponse(async_result).GetResponseStream();
                    var serilizer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(ImageList));
                    image_list = (ImageList)serilizer.ReadObject(stream);
                    if (image_list.Photos.Count > 0)
                        fetch_photo();
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    lblFileName.Text = "download faild:" + ex.Message;
                }
            });
        }

        private void fetch_photo()
        {
            img.Source = null;
            var url = image_list.Photos[image_index] + "?Width=540";
            var source = new UriImageSource
            {
                Uri = new Uri(url),
            };
            var file_name = url.Substring(url.LastIndexOf('/') + 1);
            lblFileName.Text = file_name;
            img.Source = source;
            btnPrevious.IsEnabled = image_index > 0;
            btnNext.IsEnabled = image_index < image_list.Photos.Count - 1;
        }

        void OnImagePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsLoading")
            {
                indicator.IsRunning = img.IsLoading;
            }
        }

        void OnPreviousClicked(object sender, EventArgs e)
        {
            image_index--;
            fetch_photo();
        }

        void OnNextClicked(object sender, EventArgs e)
        {
            image_index++;
            fetch_photo();
        }

        [DataContract]
        class ImageList
        {
            [DataMember(Name = "photos")]
            public List<string> Photos = null;
        }*/
    }
}