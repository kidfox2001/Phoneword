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
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                PageDataViewModel pageData = args.SelectedItem as PageDataViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }

    }

    public class PageDataViewModel
    {
        public static IList<PageDataViewModel> All { private set; get; }

        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
        {
            // Part 1. Getting Started with XAML
            new PageDataViewModel(typeof(TestHorizontalPage), "Call Testvertically  Page",
                                  "Display a Label with many properties set"),

            new PageDataViewModel(typeof(TestListViewPage), "Call TestListViewPage",
                                  "Interact with a Slider and Button"),

            new PageDataViewModel(typeof(SliderPage), "Call SliderPage",
                                  "SliderPage"),

            new PageDataViewModel(typeof(ClockPage), "Call ClockPage",
                                  "ClockPage"),
            new PageDataViewModel(typeof(HslColorScrollPage), "Call HslColorScrollPage",
                                  "HslColorScrollPage"),

            new PageDataViewModel(typeof(KeypadPage), "Call KeypadPage",
                                   "KeypadPage"),

            new PageDataViewModel(typeof(TodoRestPage), "Call TodoRestPage",
            "TodoRestPage")

        };
        }


    }
}