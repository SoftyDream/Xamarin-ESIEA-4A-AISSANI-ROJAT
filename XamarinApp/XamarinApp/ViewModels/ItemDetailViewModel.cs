﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Command DeleteCommand { get; set; }
        string itemId;
        public Item _Item;
        public Item Item
        {
            get
            {
                return _Item;
            }
            set
            {
                SetProperty(ref _Item, value);
            }
        }
        

        public ItemDetailViewModel(string itemId)
        {
            this.itemId = itemId;
            DeleteCommand = new Command(async () => await ExecuteDeleteCommandAsync());
        }

        public async Task ExecuteDeleteCommandAsync()
        {
            await DataStore.DeleteItemAsync(Item.Id);
        }

        public async Task OnAppear()
        {

            Item = await DataStore.GetItemAsync(itemId);

        }

    }
}
