using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
    public partial class App : Application
    {
        

        public static IList<string> PhoneNumbers { get; set; }

        public static TodoItemManager TodoManager { get; private set; }

        public App()
        {
            InitializeComponent();
            PhoneNumbers = new List<string>();
            TodoManager = new TodoItemManager(new RestService());

            MainPage = new NavigationPage (new MainPage2 ());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}