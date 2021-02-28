using Prism;
using Prism.Ioc;
using ProfileBook.Models;
using ProfileBook.ViewModels;
using ProfileBook.Views;
using System;
using System.IO;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
namespace ProfileBook
{
    public partial class App
    {
        /// <summary>
        /// local user
        /// </summary>
        public static UserModel CurrentUser { get; set; }
        /// <summary>
        /// local settings
        /// </summary>

        /// <summary>
        /// update list in the main page after navigation
        /// </summary>
        public static bool UpdateList { get; set; }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }
        public const string DATABASE_NAME = "friends.db";
        internal static Repository database;
        internal static Repository Database
        {
            get
            {
                if (database == null)
                {
                    database = new Repository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();


            containerRegistry.RegisterForNavigation<AddProfile, AddProfileViewModel>();
            containerRegistry.RegisterForNavigation<ChangePage, ChangePageViewModel>();
            containerRegistry.RegisterForNavigation<RegistrationPage, RegistrationPageViewModel>();
        }
    }
}
