using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Constants;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class ChangeGradeViewModel : ViewModelBase
    {
        private Toddler _selectedtoddler;
        public ICommand changeGradeButtonClicked { get; set; }
        private INavigationService _navigation;


        public ChangeGradeViewModel(INavigationService navigation)
        {
            MessagingCenter.Subscribe<Application, Toddler>(this, Constant.SendToddlerInformation, (e, toddler) =>
            {
                _selectedtoddler = toddler;
                Debug.WriteLine("in subscribe " + _selectedtoddler + " " + toddler);
                OnPropertyChanged(Constant.SelectedToddlerProperty);
            });
            _navigation = navigation;
            changeGradeButtonClicked = new Command(onSubmit);
        }


        public Toddler SelectedToddler
        {
            get
            {
                return _selectedtoddler;
            }
            set
            {
                if (_selectedtoddler != value)
                {
                    _selectedtoddler = value;
                    OnPropertyChanged(Constant.SelectedToddlerProperty);
                }
            }
        }

        private void onSubmit(object obj)
        {
            MockAPI.MockAPI.changeToddlerGradeMock(_selectedtoddler.Id, _selectedtoddler.Grade);
            _navigation.NavigateAsync(nameof(AllToddlersView));
        }

        
    }
}
