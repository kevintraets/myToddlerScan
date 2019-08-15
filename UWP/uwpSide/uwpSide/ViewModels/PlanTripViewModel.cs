using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using uwpSide.Bootstrap;
using uwpSide.Constants;
using uwpSide.Extensions;
using uwpSide.Interfaces;
using uwpSide.Models;
using uwpSide.ViewModels.Base;
using Windows.UI.Xaml.Input;

namespace uwpSide.ViewModels
{
    public class PlanTripViewModel : ViewModelBase
    {
        private readonly ITeacherService _teacherService;
        private readonly IToddlerService _toddlerService;
        private readonly ITripService _tripService;
        private ObservableCollection<Toddler> _toddlers;
        private ObservableCollection<Teacher> _teacher;
        private Teacher _selectedTeacher;
        private Toddler _selectedToddler;
        private List<Toddler> allSelectedToddlers = new List<Toddler>();
        private string _tripName;
        private DateTimeOffset _dateTrip = DateTimeOffset.Now;
        public RelayCommand confirmTripClicked { get; set; }
        private string _informationString;
        private string _tripAddedString;

        //Because I need to give a new trip an ID while mocking.
        private int index;

        public PlanTripViewModel(ITeacherService teacherService, IToddlerService toddlerService, ITripService tripService)
        {
            teacherService = AppContainer.Resolve<ITeacherService>();
            toddlerService = AppContainer.Resolve<IToddlerService>();
            tripService = AppContainer.Resolve<ITripService>();
            _teacherService = teacherService;
            _toddlerService = toddlerService;
            _tripService = tripService;
            confirmTripClicked = new RelayCommand(onTripConfirmedClick);

            //Mocking automatic assignment of a ID in a live database
            index = _tripService.getAllTrips().Count();
            
        }

        public ObservableCollection<Teacher> Teacher
        {
            get { return _teacherService.getAllTeachers().ToObservableCollection(); }

        }

        public ObservableCollection<Toddler> Toddlers
        {
            get { return _toddlerService.getAllToddlers().ToObservableCollection();  }

        }

        public Toddler SelectedToddler
        {
            get { return _selectedToddler; }

            set
            {
                _selectedToddler = value;
                allSelectedToddlers.Add(_selectedToddler);
                OnPropertyChanged(ConstantString.SelectedToddlerProperty);
                _informationString = $"{_selectedToddler.FirstName} added to trip";
                OnPropertyChanged(ConstantString.InformationStringProperty);
                Debug.WriteLine($"{DateTime.Now}, selected Toddler is: {_selectedToddler.FirstName}, length is {allSelectedToddlers.Count()}");
            }

        }

        public Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged(ConstantString.SelectedTeacherProperty);
                Debug.WriteLine($"{DateTime.Now}, selected Teacher is: {_selectedTeacher.FirstName}");
            }
        }

        public string TripName
        {
            get { return _tripName; }
            set
            {
                _tripName = value;
                OnPropertyChanged(ConstantString.TripNameProperty);
                Debug.WriteLine($"{DateTime.Now}, name of trip is: {_tripName}");
            }
        }

        public DateTimeOffset DateTrip
        {
            get { return _dateTrip; }
            set
            {
                _dateTrip = value;
                OnPropertyChanged(ConstantString.DateTripProperty);
                Debug.WriteLine($"{DateTime.Now}, date of the trip is: {_dateTrip.Date.ToShortDateString()}");
            }
        }

        public void onTripConfirmedClick()
        {
            index++;

            Trip plannedTrip = new Trip
            {
                Id = index,
                Date = _dateTrip,
                teacher = _selectedTeacher,
                TeacherId = _selectedTeacher.Id,
                Title = _tripName,
                Toddlers = allSelectedToddlers
            };

            _tripService.addTrip(plannedTrip);
            allSelectedToddlers = new List<Toddler>();
            Debug.WriteLine($"{DateTime.Now}, planned trip added");
            _tripAddedString = ConstantString.TripAddedString;
            OnPropertyChanged(ConstantString.TripAddedStringProperty);
           
        }

        public string InformationString
        {
            get { return _informationString; }
            set
            {
                _informationString = value;
                OnPropertyChanged(ConstantString.InformationStringProperty);
                Debug.WriteLine($"{DateTime.Now}, informationstring is {_informationString}");
            }
        }
        public string TripAddedString
        {
            get { return _tripAddedString; }
        }

    }
}
