using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Bootstrap;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class ScanViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private IScanService _scanService;
        private IToddlerService _toddlerService;
        private ITripService _tripService;
        private ITeacherService _teacherService;
        private string _tripName = "tripName";
        private string _scanName = "scanName";
        private Toddler scannedToddler1;
        private Toddler scannedToddler2;
        private Trip trip;
        private Teacher teacher;
        private List<Toddler> scannedToddlers = new List<Toddler>();
        private Scan scan;
        public ICommand QRScanned { get; set; }

        public ScanViewModel(INavigationService navigationService, IScanService scanService, IToddlerService toddlerService, ITripService tripService, ITeacherService teacherService)
        {
            
            scanService = AppContainer.Resolve<IScanService>();
            toddlerService = AppContainer.Resolve<IToddlerService>();
            tripService = AppContainer.Resolve<ITripService>();
            teacherService = AppContainer.Resolve<ITeacherService>();
            _navigationService = navigationService;
            _scanService = scanService;
            _toddlerService = toddlerService;
            _tripService = tripService;
            _teacherService = teacherService;
            QRScanned = new Command(tripScan);
        }

        public string TripName
        {
            get { return _tripName; }
            set
            {
                _tripName = value;
                OnPropertyChanged("TripName");
            }
        }
        public string ScanName
        {
            get { return _scanName; }
            set
            {
                _scanName = value;
                OnPropertyChanged("ScanName");
            }
        }


        //Mocking a scan


        public void tripScan()
        {

            //Create a new scan
            //Scan returns name and last name from a toddler
            //Get toddler from database
            //Add that toddler to a list
            //If needed, scan another toddler
            scannedToddler1 = _toddlerService.getToddlerById(1);
            scannedToddlers.Add(scannedToddler1);
            scannedToddler2 = _toddlerService.getToddlerById(2);
            scannedToddlers.Add(scannedToddler2);
            //Do a lookup in the database for the correct Trip
            trip = _tripService.getTripById(1);
            //Do a lookup in the database for the correct Teacher
            teacher = _teacherService.getTeacherById(1);
            //Create a new Scan with gathered data
            scan = new Scan
            {
                Id = 5,
                Name = _tripName,
                TeacherId = teacher.Id,
                teacher = teacher,
                TripId = trip.Id,
                trip = trip,
                Toddlers = scannedToddlers
            };
            _scanService.addScan(scan);
            Debug.WriteLine("scan added");

        }

    }
}
