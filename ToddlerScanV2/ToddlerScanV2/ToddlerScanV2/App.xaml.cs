using System;
using ToddlerScanV2.Constants;
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

            NavigationService.Configure(Constant.loginView, typeof(LoginView));
            NavigationService.Configure(Constant.changeGradeView, typeof(ChangeGradeView));
            NavigationService.Configure(Constant.allToddlersView, typeof(AllToddlersView));
            NavigationService.Configure(Constant.scanView, typeof(ScanView));
            var mainPage = ((NavigationService)NavigationService).SetRootPage(Constant.loginView);

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
