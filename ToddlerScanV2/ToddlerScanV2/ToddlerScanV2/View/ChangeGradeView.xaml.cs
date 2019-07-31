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
	public partial class ChangeGradeView : ContentPage
	{
		public ChangeGradeView (Toddler toddler)
		{
			InitializeComponent ();
            BindingContext = new ChangeGradeViewModel(toddler, Navigation);

        }
	}
}