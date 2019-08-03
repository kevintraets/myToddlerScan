using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToddlerScanV2.Models;
using ToddlerScanV2.Services.General;
using ToddlerScanV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToddlerScanV2.Contracts.Repository.Services.General;

namespace ToddlerScanV2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeGradeView : ContentPage
	{
        private INavigationService _navigationService { get; } = App.NavigationService;
		public ChangeGradeView ()
		{
			InitializeComponent ();
            BindingContext = new ChangeGradeViewModel(_navigationService);

        }
	}
}