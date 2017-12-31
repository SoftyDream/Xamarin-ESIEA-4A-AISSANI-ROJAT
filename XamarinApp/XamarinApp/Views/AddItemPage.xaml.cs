using System;

using Xamarin.Forms;
using XamarinApp.ViewModels;

namespace XamarinApp
{
    public partial class AddItemPage : ContentPage
    {
        AddItemViewModel viewModel;

        public AddItemPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "New task",
                Description = "Task description."
            };

            viewModel = new AddItemViewModel(item);
            BindingContext = viewModel;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {

            await viewModel.ExecuteSaveCommandAsync();
            await Navigation.PopToRootAsync();

        }
    }
}
