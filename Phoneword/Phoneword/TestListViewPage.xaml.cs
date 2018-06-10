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
    public partial class TestListViewPage : ContentPage
    {
        public TestListViewPage()
        {
            InitializeComponent();

            var listView = new ListView
            {
                RowHeight = 40
            };

            listView.ItemsSource = new TodoItem[] {
                new TodoItem { Name = "Buy pears" },
                new TodoItem { Name = "Buy oranges", Done=true} ,
                new TodoItem { Name = "Buy mangos" },
                new TodoItem { Name = "Buy apples", Done=true },
                new TodoItem { Name = "Buy bananas", Done=true }
                };

            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            listView.ItemSelected += async (sender, e) =>
            {
                await DisplayAlert("Tapped!", ((TodoItem)e.SelectedItem).Name + " was tapped.", "OK");
            };

            //listView.ItemSelected += async (sender, e) => {
            //    var todoItem = (TodoItem)e.SelectedItem;
            //    var todoPage = new TodoItemPage(todoItem); // so the new page shows correct data
            //    await Navigation.PushAsync(todoPage);
            //};

            // ex (แบบธรรมดา)        

            //        listView.ItemsSource = new string[]
            //        {
            //"Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
            //        };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };


        }
    }

    public class TodoItem
    {
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}