using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Extensions;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using ToddlerScanV2.Constants;
using Xamarin.Forms;
using ToddlerScanV2.Bootstrap;

namespace ToddlerScanV2.ViewModels
{
    public class AllToddlersViewModel : ViewModelBase
    {
        private Toddler _selectedToddler;
        private readonly IToddlerService _toddlerService;
        private INavigationService _navigation;
        public ICommand scanButtonClicked { get; set; }


        public AllToddlersViewModel(INavigationService navigation, IToddlerService toddlerService)
        {
            toddlerService = AppContainer.Resolve<IToddlerService>();
            _navigation = navigation;
            _toddlerService = toddlerService;
            scanButtonClicked = new Command(OnScanButtonClick);
        }

        public Toddler SelectedToddler
        {
            get { return _selectedToddler; }
            set
            {
                if (_selectedToddler != value)
                    _selectedToddler = value;
                ClickedToddler();
            }
        }

        private void ClickedToddler()
        {
             _navigation.NavigateAsync(nameof(ChangeGradeView));
            MessagingCenter.Send(Application.Current, Constant.sendToddlerInformation, _selectedToddler);
            Debug.WriteLine(Constant.sendToddlerInformation + _selectedToddler);
        }

        private void OnScanButtonClick(object obj)
        {
            _navigation.NavigateAsync(nameof(ScanView));
        }

        public ObservableCollection<Toddler> MockToddlers
        {
            get { return _toddlerService.getAllToddlers().ToObservableCollection();  }
        }
    }
}
