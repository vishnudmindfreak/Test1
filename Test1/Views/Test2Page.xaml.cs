using Test1.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Test1.Views
{
    public sealed partial class Test2Page : Page
    {
        public Test2ViewModel ViewModel { get; } = new Test2ViewModel();
        public Test2Page()
        {
            InitializeComponent();
        }
    }
}
