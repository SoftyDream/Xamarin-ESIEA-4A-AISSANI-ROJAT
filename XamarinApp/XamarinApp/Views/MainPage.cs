using System;

using Xamarin.Forms;

namespace XamarinApp
{

    public class MainPage : TabbedPage //Navigating between pages using tabs
    {
        public MainPage()
        {

            Page itemsPage;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS: //iOS Running platform

                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "To do list"
                    };
                   
                    break;

                    //Others
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "To do list"
                    };
                    
                    break;
            }
            Children.Add(itemsPage); //Page in Page
        }
    }
}
