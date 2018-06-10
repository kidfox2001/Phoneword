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
	public partial class TestHorizontalPage : ContentPage
	{
		public TestHorizontalPage ()
		{
			InitializeComponent ();

            //Padding = new Thickness(20);
            var red = new Label
            {
                Text = "Stop",
                BackgroundColor = Color.Red,
                FontSize = 20,
                WidthRequest = 100
            };
            var yellow = new Label
            {
                Text = "Slow down",
                BackgroundColor = Color.Yellow,
                FontSize = 20,
                WidthRequest = 100
            };
            var green = new Label
            {
                Text = "Go",
                BackgroundColor = Color.Green,
                FontSize = 20,
                WidthRequest = 200
            };

            Content = new StackLayout
            {
                Spacing = 40,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = { red, yellow, green }
            };

        }
	}
}