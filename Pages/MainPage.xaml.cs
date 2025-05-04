using System.Diagnostics;
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
        private string main;
        private string budgetType;
        private string celebrationPlace;

        private string fabrics;
        private string dishes;
        private string furniture;
        private string decor;

        private string lightProducer;
        private string show;
        private string coverGroup;
        private string firstDance;
        private string firework;
        private string fireShow;

        private string photoZone;
        private string videoGraph;

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
            Frame.Navigate(typeof(ResultPage), null, new SlideNavigationTransitionInfo());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"{main}, {budgetType}, {celebrationPlace}, {fabrics}");
        }
    }

    class ResultPageArgs
    {
        public string Main { get; set; }
        public string BudgetType { get; set; }
        public string CelebrationPlace { get; set; }

        public string Fabrics { get; set; }
        public string Dishes { get; set; }
        public string Furniture { get; set; }
        public string Decor {  get; set; }

        public string LightProducer { get; set; }
        public string Show {  get; set; }
        public string CoverGroup {  get; set; }
        public string FirstDance {  get; set; }
        public string Firework {  get; set; }
        public string FireShow {  get; set; }

        public string PhotoZone {  get; set; }
        public string VideoGraph {  get; set; }
    }
}