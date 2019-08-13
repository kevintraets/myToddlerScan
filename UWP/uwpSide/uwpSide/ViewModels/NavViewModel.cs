using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Bootstrap;
using uwpSide.Interfaces;
using uwpSide.Services;
using uwpSide.Views;

namespace uwpSide.ViewModels
{
    public class NavViewModel
    {
        private INavigateService _nav = new NavigateService();
        
        public RelayCommand planTripClicked { get; set; }
        public NavViewModel()
        {
            planTripClicked = new RelayCommand(clickedOnPlanTrip);
        }

        //I'm not able to bind this on startup...
        private void clickedOnPlanTrip()
        {
            _nav.NavigateTo(typeof(PlanTripView));
            Debug.WriteLine("clicked on plan trip");
        }
    }
}
