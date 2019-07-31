using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Models;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private User user;

        public User User
        {
            get { return user; }
            set
            {
                if (user != value)
                    user = value;
            }
        }  
    }
}
