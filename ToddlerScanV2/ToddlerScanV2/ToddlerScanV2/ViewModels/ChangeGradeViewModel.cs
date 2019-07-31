using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class ChangeGradeViewModel : ViewModelBase
    {
        private Toddler _selectedToddler;
        private INavigation _navigation;


        public ChangeGradeViewModel(Toddler selectedToddler, INavigation navigation)
        {
            _selectedToddler = selectedToddler;
            _navigation = navigation;
            changeGradeButtonClicked = new Command(onSubmit);
        }

        public Toddler SelectedToddler
        {
            get { return _selectedToddler; }
            set
            {
                if (_selectedToddler != value)
                {
                    _selectedToddler = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand changeGradeButtonClicked { get; set; }

        private void onSubmit(object obj)
        {
            MockAPI.MockAPI.changeToddlerGradeMock(_selectedToddler.Id, _selectedToddler.Grade);
            _navigation.PushAsync(new AllToddlersView());
        }
    }
}
