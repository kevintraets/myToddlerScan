using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;

namespace ToddlerScanV2.ViewModels
{
    public class ScanViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private IScanService _scanService;
        private string _testString = "teststring";

        public ScanViewModel(INavigationService navigationService, IScanService scanService)
        {
            _navigationService = navigationService;
            _scanService = scanService;
        }

    }
}
