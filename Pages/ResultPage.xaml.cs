using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace WeddingOrganization.Pages
{
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += NavigateBack;
        }

        private void NavigateBack(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack(new SlideNavigationTransitionInfo());
                e.Handled = true;
            }
        }
    }
}
