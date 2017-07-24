using Test1.Models;
using Test1.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Test1.Views
{
    public sealed partial class HomeDetailPage : Page
    {
        public HomeDetailViewModel ViewModel { get; } = new HomeDetailViewModel();
        public HomeDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as Order;
        }
    }
}
