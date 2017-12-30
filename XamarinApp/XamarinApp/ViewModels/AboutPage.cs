using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp.ViewModels
{
    public partial class AboutPage : ContentPage
    {
        InitializeComponent();
        BindingContext = new MyViewModel();
    }
}
