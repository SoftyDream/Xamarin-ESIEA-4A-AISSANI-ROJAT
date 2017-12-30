using System;

using Xamarin.Forms;

namespace XamarinApp
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "To do list"
                    };
                   
                    break;
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "To do list"
                    };
                    
                    break;
            }
            Children.Add(itemsPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
