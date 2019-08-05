using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Extensions;
using ToddlerScanV2.Models;
using ToddlerScanV2.View;
using ToddlerScanV2.ViewModels.Base;
using Xamarin.Forms;

namespace ToddlerScanV2.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        //Variables
        public ICommand loginButtonPressed { get; set; }
        public ICommand signUpButtonPressed { get; set; }
        private string username = "";
        private string password = "";
        User user = new User();
        private IValidateUserService _validateUserService;
        private INavigationService _navigation;
        public event PropertyChangedEventHandler PropertyChanged;

        //ctor
        public LoginViewModel(INavigationService navigation, IValidateUserService validateUser)
        {
            _navigation = navigation;
            _validateUserService = validateUser;
            loginButtonPressed = new Command(onSubmit);
            signUpButtonPressed = new Command(onSignUp);
        }


        public string Username {
            get {
                Console.WriteLine(username.Length + " test ");
                return username; }
            set
            {
                username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Username"));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private void onSubmit(object obj)
        {
            user.Username = username;
            user.Password = password;
            List<User> allUsers = _validateUserService.getAllUsers();
            if (_validateUserService.ValidateUser(allUsers, user))
            {
                _navigation.NavigateAsync(nameof(AllToddlersView));
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Failed login", "Not Authorized", "Ok");
                _navigation.NavigateAsync(nameof(LoginView));
            }

        }

        private void onSignUp()
        {
            if (!string.IsNullOrEmpty(user.Username)&&!string.IsNullOrEmpty(user.Password))
            {
                user.Username = username;
                user.Password = password;
                _validateUserService.userSignIn(user);
                App.Current.MainPage.DisplayAlert("User added", "You can log in", "Ok");
                _navigation.NavigateAsync(nameof(LoginView));
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Fill in all fields", "Ok");
            }

        }
        
    }
}
