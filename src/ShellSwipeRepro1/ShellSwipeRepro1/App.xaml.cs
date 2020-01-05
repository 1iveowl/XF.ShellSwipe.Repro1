using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellSwipeRepro1.Services;
using ShellSwipeRepro1.Views;

namespace ShellSwipeRepro1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
