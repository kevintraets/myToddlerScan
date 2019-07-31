using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToddlerScanV2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllToddlersView : ContentPage
	{
		public AllToddlersView ()
		{
			InitializeComponent ();
            BindingContext = new AllToddlersViewModel(Navigation);
		}
	}
}