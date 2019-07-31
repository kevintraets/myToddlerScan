using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToddlerScanV2.Models;
using ToddlerScanV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToddlerScanV2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
        public User user;
		public LoginView ()
		{
            InitializeComponent();

            //Setting bindingContext
            BindingContext = new User();

            //setup for receiving login confirm from MessageCenter
            MessagingCenter.Subscribe<User, string>(this, "LoginAlert", (sender,username) =>
            {
                DisplayAlert("Title", username, "oké");
                Navigation.PushAsync(new AllToddlersView());
            });












            //Maybe neccessary in the fut
            //entry_username.Completed += (object sender, EventArgs e) =>
            //{
            //    entry_password.Focus();
            //};
            //entry_password.Completed += (object sender, EventArgs e) =>
            //{
            //    user.SignInProcedure.Execute(null);
            //};
        }
	}
}