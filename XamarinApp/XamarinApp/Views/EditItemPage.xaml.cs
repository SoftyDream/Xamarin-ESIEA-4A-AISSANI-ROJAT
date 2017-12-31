using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.ViewModels;

namespace XamarinApp.Views
{
    public partial class EditItemPage : ContentPage
    {
        EditItemViewModel viewModel;

        public EditItemPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "New task",
                Description = "Task description."
            };



            BindingContext = viewModel = new EditItemViewModel(item);
        }

        public EditItemPage(EditItemViewModel viewModel)
        {
            InitializeComponent();
            //BindingContext = viewModel;
            BindingContext = this.viewModel = viewModel;
        }

        async void Update_Clicked(object sender, EventArgs e)
        {
            await viewModel.ExecuteUpdateCommandAsync();
            await Navigation.PopAsync();
        }
    }
}