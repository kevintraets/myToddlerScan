using Autofac;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Bootstrap;
using uwpSide.Constants;
using uwpSide.Extensions;
using uwpSide.Interfaces;
using uwpSide.Models;
using uwpSide.ViewModels.Base;

namespace uwpSide.ViewModels
{
    public class TripViewModel : ViewModelBase
    {
        private readonly ITripService _tripService;
        private Trip _selectedTrip;
        private ObservableCollection<Toddler> _toddlers;
        private int tripId;

        public TripViewModel(ITripService tripService)
        {
            tripService = AppContainer.Resolve<ITripService>();
            _tripService = tripService;
        }

        public List<Trip> Trips
        {
            get { return _tripService.getAllTrips(); }
        }

        public ObservableCollection<Toddler> Toddlers
        {

            get
            {
                //Because first time in, tripId == null
                try
                {
                    return _tripService.getAllToddlersByTripId(tripId).ToObservableCollection();

                }
                catch
                {

                    return null;
                }
            }

            set
            {
                _toddlers = value;
                OnPropertyChanged(ConstantString.ToddlersProperty);

            }
        }

        public Trip SelectedTrip
        {
            get { return _selectedTrip; }

            set
            {
                _selectedTrip = value;
                OnPropertyChanged(ConstantString.SelectedTripProperty);
                ClickedTrip();

            }
        }


        private void ClickedTrip()
        {
            tripId = _selectedTrip.Id;
            Debug.WriteLine("in clicked trip: " + _selectedTrip.Toddlers.Count() + tripId);
            OnPropertyChanged(ConstantString.ToddlersProperty);
        }
    }
}
