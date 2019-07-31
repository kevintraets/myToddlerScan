using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.View;
using Xamarin.Forms;

namespace ToddlerScanV2.Models
{
    public class User 
    {

        public string username;

        public User()
        {
            SignInProcedure = new Command(OnSubmit);
        }

        //Getters and setters
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }
        public string password;

        public string Password
        {
            get { return password; }

            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ICommand SignInProcedure { get; set; }
        public NavigationPage MainPage { get; private set; }

        public void OnSubmit()
        {
            if (!string.IsNullOrEmpty(Username))
            {
                MessagingCenter.Send(this, "LoginAlert", Username);
            }
        }

    }
}
