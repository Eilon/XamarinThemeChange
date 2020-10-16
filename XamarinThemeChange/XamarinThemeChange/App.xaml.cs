using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinThemeChange
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            RequestedThemeChanged += Current_RequestedThemeChanged;
        }

        int num;

        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            ((MainPage)MainPage).ThemeUpdates.Add($"{num}: {e.RequestedTheme}");
            num++;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
