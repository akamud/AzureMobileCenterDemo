using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCenterDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Analytics.TrackEvent("Página inicial aberta", new Dictionary<string, string> { ["Idade"] = "20" });

            btnCrash.Clicked += (s, e) =>
            {
                //Crashes.GenerateTestCrash();
                TestCrash();
            };
        }

        private void TestCrash()
        {
            throw new NotImplementedException();
        }
    }
}
