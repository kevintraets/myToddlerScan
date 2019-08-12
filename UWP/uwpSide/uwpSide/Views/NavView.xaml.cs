using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using uwpSide.Interfaces;
using uwpSide.Services;
using uwpSide.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpSide.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavView : Page
    {
        public NavView()
        {
            this.InitializeComponent();
            this.DataContext = new NavViewModel();
        }
        //Temporary Navigation
        private void TripView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TripView));
        }

        private void PlanTrip_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PlanTripView));
        }

        private void CreateCode_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ScanQRView));
        }
    }
}
