﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp.ViewModels
{ 
    public class EditItemViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public Command UpdateCommand { get; set; }

        public EditItemViewModel(Item item)
        {
            Item = new Item
            {
                Id = item.Id,
                Text = item.Text,
                Description = item.Description,
                /*Date = item.Date,
                Time = item.Time,*/
            };

            Title = Item?.Text; //Set title as task's name

            UpdateCommand = new Command(async () => await ExecuteUpdateCommandAsync());
        }

        public async Task ExecuteUpdateCommandAsync()
        {
            await DataStore.UpdateItemAsync(Item);
        }
    }
}
