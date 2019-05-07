using LocalSqlDbLibrary;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDbTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BlogHelper.InitializeDatabase(Path.Combine(FileSystem.AppDataDirectory, "blog.db"));
            MainPage = new MainPage();
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
