using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Interfaces;
using uwpSide.Views;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace uwpSide.Services
{
    public class NavigateService : INavigateService
    {

        public void NavigateTo(Type viewType)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(viewType);
        }

        public void GoBack()
        {

        }
    }
}
