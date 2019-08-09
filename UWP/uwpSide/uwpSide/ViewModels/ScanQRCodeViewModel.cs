using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Bootstrap;
using uwpSide.Extensions;
using uwpSide.Interfaces;
using uwpSide.Models;
using uwpSide.ViewModels.Base;
using Windows.UI.Xaml.Media.Imaging;
using ZXing;
using ZXing.Mobile;
using ZXing.QrCode;

namespace uwpSide.ViewModels
{
    public class ScanQRCodeViewModel : ViewModelBase
    {
        private string _firstName;
        private string _lastName;
        private string _grade;
        private IToddlerService _toddlerService;
        private ObservableCollection<Toddler> _mockToddlers;
        private Toddler _selectedToddler;



        public ScanQRCodeViewModel(IToddlerService toddlerService)
        {
            toddlerService = AppContainer.Resolve<IToddlerService>();
            _toddlerService = toddlerService;
            RegisterToddler = new RelayCommand(onRegisterToddler);
        }

        public string  FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Grade
        {
            get { return _grade; }
            set
            {
                _grade = value;
                OnPropertyChanged("Grade");
            }
        }

        public Toddler SelectedToddler
        {
            get { return _selectedToddler; }
            set
            {
                if(_selectedToddler != value)
                {
                    _selectedToddler = value;
                    OnPropertyChanged("SelectedToddler");
                    if(_selectedToddler != null)
                    {
                        onClickToddlerCreateQRCode($"{_selectedToddler.FirstName}, {_selectedToddler.LastName}");
                        Debug.WriteLine(_selectedToddler.FirstName);
                    }

                }

            }
        }

        public ObservableCollection<Toddler> MockToddlers
        {
            get { return _toddlerService.getAllToddlers().ToObservableCollection(); }
            set
            {
                _mockToddlers = value;
                OnPropertyChanged("MockToddlers");
            }
        }

        
        public WriteableBitmap QRImageFromList { get; set; }
        public RelayCommand GenerateQRCode { get; set; }
        public RelayCommand RegisterToddler { get; set; }


        private void onRegisterToddler()
        {
            Toddler toddler = new Toddler
            {
                FirstName = _firstName,
                LastName = _lastName,
                Grade = _grade
            };
            _toddlerService.addToddler(toddler);
            OnPropertyChanged("MockToddlers");
            Debug.WriteLine(_toddlerService.getAllToddlers().Count());
        }

        private void onClickToddlerCreateQRCode(string name)
        {
            Debug.WriteLine("Clicked on toddler");
            var options = new QrCodeEncodingOptions()
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 1000,
                Height = 1000,
            };
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            string qrcodeString = name;
            QRImageFromList = writer.Write(qrcodeString);
            OnPropertyChanged("QRImageFromList");
        }
    }
}
