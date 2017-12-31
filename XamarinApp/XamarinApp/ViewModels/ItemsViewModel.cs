using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Views;

namespace XamarinApp
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "To do list";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        }

        public async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
            {
                return; /*Read and Write acces denied. Read OR Write only*/}
            IsBusy = true;

            var items = await DataStore.GetItemsAsync(true); 

            foreach (var item in items)
            {
                Items.Add(item); //complete
            }

            IsBusy = false;
     
        }
    }
}
