﻿using System;

using Xamarin.Forms;

namespace XamarinApp
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage/*,aboutPage = null*/;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "To do list"
                    };
                    /*aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };
                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";*/
                    break;
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "To do list"
                    };
                    /*
                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };*/
                    break;
            }

            //Children.Add(aboutPage);
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
