using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace WeddingOrganization.Pages
{
    public sealed partial class ResultPage : Page
    {
        private ResultPageArgs args;

        private Visibility restaurantVisibility = Visibility.Collapsed;
        private Visibility estateVisibility = Visibility.Collapsed;

        public ResultPage()
        {
            InitializeComponent();

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += NavigateBack;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is ResultPageArgs args)
            {
                this.args = args;

                switch (args.CelebrationPlace)
                {
                    case "Ресторан":
                        restaurantVisibility = Visibility.Visible;
                        break;
                    case "Усадьба":
                        estateVisibility = Visibility.Visible;
                        break;
                }
            }
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
