using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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
        private INavigationService _navigation;


        public ChangeGradeViewModel(INavigationService navigation)
        {
            //------------View isn't corresponding---------------------
            MessagingCenter.Subscribe<Application, Toddler>(this, "send", (e, toddler) =>
            {
                _selectedtoddler = toddler;
                Console.WriteLine("in subscribe " + _selectedtoddler + " " + toddler);
            });
            _navigation = navigation;
            changeGradeButtonClicked = new Command(onSubmit);

        }

        public ICommand changeGradeButtonClicked { get; set; }

        public Toddler SelectedToddler
        {
            get
            {
                Console.WriteLine("get ");
                return _selectedtoddler;
            }
            set
            {
                if (_selectedtoddler != value)
                {
                    _selectedtoddler = value;
                    OnPropertyChanged();
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
