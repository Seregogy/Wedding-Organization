using Wedding_Organization.Helpers;
using WeddingOrganization.ArgsData;
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

        private int totalCost;
        public string TotalCost => $"~{totalCost.SplitDigits()} руб.";

        private int mainCost;
        public string MainCost => $"{mainCost.SplitDigits()} руб.";

        private int decorCost;
        public string DecorCost => $"{decorCost.SplitDigits()} руб.";

        private int showCost;
        public string ShowCost => $"{showCost.SplitDigits()} руб.";

        private int additionalCost;
        public string AdditionalCost => $"{additionalCost.SplitDigits()} руб.";


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
                this.args = args;

            mainCost = this.args.CalculateMain();
            decorCost = this.args.CalculateDecor();
            showCost = this.args.CalculateShow();
            additionalCost = this.args.CalculateAdditional();

            totalCost = this.args.CalculateTotalCost();
            GetCelebrationPlace(this.args, ref restaurantVisibility, ref estateVisibility);
        }

        private void GetCelebrationPlace(ResultPageArgs args, ref Visibility restaurant, ref Visibility estate)
        {
            switch (args.CelebrationPlace)
            {
                case "Ресторан":
                    restaurant = Visibility.Visible;
                    break;
                case "Усадьба":
                    estate = Visibility.Visible;
                    break;

                default:
                    restaurant = Visibility.Visible;
                    break;
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
