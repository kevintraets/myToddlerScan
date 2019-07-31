using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Extensions;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class AllToddlersViewModel : ViewModelBase
    {
        private Toddler _selectedToddler;
        //private readonly IToddlerService _toddlerService;
        private INavigation _navigation;


        public AllToddlersViewModel(INavigation navigation)
        {
            _navigation = navigation;
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
            //Console.WriteLine(_selectedToddler.FirstName);
            _navigation.PushAsync(new ChangeGradeView(_selectedToddler));
            
        }

        //Mocking
        public ObservableCollection<Toddler> MockToddlers
        {
            get { return MockAPI.MockAPI.GetAllToddlersMock().ToObservableCollection(); }
            //get { return _toddlerService.getAllToddlers().ToObservableCollection();  }
        }
    }
}
