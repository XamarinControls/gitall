using GitAll.Core;
using GitAll.Forms.Services;
using GitAll.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitAll.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        private CoreApp _coreApp;

        public App()
        {
            InitializeComponent();

            _coreApp = new CoreApp();
            _coreApp.Init(new MyDependencyService());
                                        
            MainPage = new NavigationPage(new MainView());
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
