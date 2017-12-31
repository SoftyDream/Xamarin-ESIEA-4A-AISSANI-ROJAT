using System;

using Xamarin.Forms;
using XamarinApp.ViewModels;
using XamarinApp.Views;

namespace XamarinApp
{

    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public ItemDetailPage()
        {
            InitializeComponent(); 
        }

        public ItemDetailPage(string itemId)
        {
            InitializeComponent();
            //BindingContext = viewModel;
            BindingContext = this.viewModel = new ItemDetailViewModel(itemId); 
        }

        //@☻Override
        protected async override void OnAppearing()
        {
            base.OnAppearing();
             await this.viewModel.OnAppear();
        }

        async void DeleteItem_Clicked(object sender, EventArgs e)
        { //Delete and nav to root
            await viewModel.ExecuteDeleteCommandAsync();
            await Navigation.PopToRootAsync();
        }

        async void EditItem_Clicked(object sender, EventArgs e)
        { //Nav to edit
            await Navigation.PushAsync(new EditItemPage(new EditItemViewModel (viewModel.Item)));
        }

    }
}
