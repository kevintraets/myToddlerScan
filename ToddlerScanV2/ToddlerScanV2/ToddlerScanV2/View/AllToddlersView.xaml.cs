using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Contracts.Repository.Services.General;
using ToddlerScanV2.Services.Data;
using ToddlerScanV2.Services.General;
using ToddlerScanV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToddlerScanV2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllToddlersView : ContentPage
	{
        private INavigationService _navigationService { get; } = App.NavigationService;
        private IToddlerService _toddlerService;
        
		public AllToddlersView ()
		{
			InitializeComponent ();
            BindingContext = new AllToddlersViewModel(_navigationService, _toddlerService);
		}
	}
}