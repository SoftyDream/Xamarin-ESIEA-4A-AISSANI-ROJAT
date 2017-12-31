﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace XamarinApp
{
    public class BaseViewModel : INotifyPropertyChanged
    { 
        public MockDataStore DataStore = new MockDataStore();
        //public IDataStore<Item> DataStore => DependencyService.Get <IDataStore.Get<IDataStore<Item>>() ?? new MockDataStore();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)/*...*/
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        /* #region INotifyPropertyChanged
          public event PropertyChangedEventHandler PropertyChanged
          protected void OnPropertyChanged([CallerMemberName] string propertyName = "")...
          #endregion
          */
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged; //Change if property change for real
            if (changed == null) //if not, continue
            {

                return;
            }
            else
            {
                changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }
        }
        #endregion
    }
}
