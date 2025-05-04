using System.Diagnostics;
using WeddingOrganization.ArgsData;
using WeddingOrganization.Helpers;
using WeddingOrganization.Pages;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace WeddingOrganization
{
    public sealed partial class MainPage : Page
    {
        private string guestCount = "50";
        private string budgetType = "Базовый";
        private string celebrationPlace = "Усадьба";

        private string fabrics = "Нет";
        private string dishes = "Нет";
        private string furniture = "Нет";
        private string decor = "Нет";

        private string lightProducer = "Нет";
        private string show = "Нет";
        private string coverGroup = "Нет";
        private string firstDance = "Нет";
        private string firework = "Нет";
        private string fireShow = "Нет";

        private string photoZone = "Нет";
        private string videoGraph = "Нет";

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void ResultButton(object sender, RoutedEventArgs e)
        {
            var args = new ResultPageArgs
            {
                GuestCount = int.Parse(guestCount),
                BudgetType = budgetType,
                CelebrationPlace = celebrationPlace,

                Fabrics = fabrics.ToVisibility(),
                Dishes = dishes.ToVisibility(),
                Furniture = furniture.ToVisibility(),
                Decor = decor.ToVisibility(),

                LightProducer = lightProducer.ToVisibility(),
                Show = show.ToVisibility(),
                CoverGroup = coverGroup.ToVisibility(),
                FirstDance = firstDance.ToVisibility(),
                Firework = firework.ToVisibility(),
                FireShow = fireShow.ToVisibility(),

                PhotoZone = photoZone.ToVisibility(),
                VideoGraph = videoGraph.ToVisibility()
            };

            Frame.Navigate(typeof(ResultPage), args, new SlideNavigationTransitionInfo());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"{guestCount}, {budgetType}, {celebrationPlace}, {fabrics}");
        }

        private void BudgedTypeChanged(object sender, SelectionChangedEventArgs e) =>
            budgetType = (sender as ComboBox).SelectedValue.ToString();

        private void CelebrationPlaceChanged(object sender, SelectionChangedEventArgs e) =>
            celebrationPlace = (sender as ComboBox).SelectedValue.ToString();
    }
}