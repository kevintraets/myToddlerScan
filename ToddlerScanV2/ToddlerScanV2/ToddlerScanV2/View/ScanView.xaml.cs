using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Services.Data;
using ToddlerScanV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToddlerScanV2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanView : ContentPage
    {
        private INavigationService _navigationService { get; } = App.NavigationService;
        private IScanService _scanService = new ScanService();


        public ScanView()
        {
            InitializeComponent();
            BindingContext = new ScanViewModel(_navigationService, _scanService);
            TestLabel.Text = "Kevin";

        }
    }
}