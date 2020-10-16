using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinThemeChange
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public ObservableCollection<string> ThemeUpdates { get; } = new ObservableCollection<string>();
        public string CurrentTheme => $"Current theme: {Application.Current.RequestedTheme}";
    }
}
