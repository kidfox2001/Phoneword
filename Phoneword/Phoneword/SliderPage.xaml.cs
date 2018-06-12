using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SliderPage : ContentPage
	{
		public SliderPage ()
		{
            InitializeComponent();

            slider.Value = 0.5;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 20, 0, 0);
                    break;
                case Device.UWP:
                    Padding = new Thickness(30, 20, 0, 0);
                    break;
                case Device.macOS:
                default:
                    // This is just an example. You wouldn't actually need to do this, since Padding is already 0 by default.
                    this.Padding = new Thickness(0);
                    break;
            }

            // แบบที่ comment ล้าสมัย

            //if (Device.OS == TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}
            //else if (Device.OS == TargetPlatform.Android)
            //{
            //    Padding = new Thickness(10, 20, 0, 0);
            //}
            //else if (Device.OS == TargetPlatform.WinPhone)
            //{
            //    Padding = new Thickness(30, 20, 0, 0);
            //}


            //Padding = Device.OnPlatform<Thickness>(
            //     iOS: new Thickness(0, 20, 0, 0),
            //     Android: new Thickness(10, 20, 0, 0),
            //     WinPhone: new Thickness(30, 20, 0, 0)
            //     );


            //Device.OnPlatform(
            //    iOS: () => { Padding = new Thickness(0, 20, 0, 0); }
            //    );

        }
	}
}