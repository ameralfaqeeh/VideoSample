
using MediaManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace playvideo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private  void BtnPlayLocal_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                CrossMediaManager.Current.PlayFromResource("minions.mp4");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                CrossMediaManager.Current.Play("file:///android_asset/minions.mp4");
            }
          
        }

     
    }
}
