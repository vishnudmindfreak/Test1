using Test1.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Test1.Views
{
    public sealed partial class Page1Page : Page
    {
        public Page1ViewModel ViewModel { get; } = new Page1ViewModel();
        public Page1Page()
        {
            InitializeComponent();
        }
    }
}
