using System;
using Xamarin.Forms;

namespace Phoneword
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + translatedNumber + "?",
                    "Yes",
                    "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    App.PhoneNumbers.Add(translatedNumber);
                    callHistoryButton.IsEnabled = true;
                    dialer.Dial(translatedNumber);
                }
                   
            }
        }

        async void OnCallHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CallHistoryPage());
        }

        async void OnCallTestPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage1());
        }

        async void OnCallTestHorizontalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestHorizontalPage());
        }

        async void OnCallTestListViewPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestListViewPage());
        }

        async void btnSliderPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SliderPage());
        }

        async void btnClockPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClockPage());
        }

        async void btnHslColorScrollPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HslColorScrollPage());
        }
    }
}