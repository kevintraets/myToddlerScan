using System;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Services.General;
using ToddlerScanV2.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ToddlerScanV2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            NavigationService.Configure("LoginView", typeof(LoginView));
            NavigationService.Configure("ChangeGradeView", typeof(ChangeGradeView));
            NavigationService.Configure("AllToddlersView", typeof(AllToddlersView));
            var mainPage = ((NavigationService)NavigationService).SetRootPage("LoginView");

            MainPage = mainPage;

        }

        public static INavigationService NavigationService { get; } = new NavigationService();

        

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
