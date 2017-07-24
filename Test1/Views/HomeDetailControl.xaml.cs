using Test1.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Test1.Views
{
    public sealed partial class HomeDetailControl : UserControl
    {
        public Order MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Order; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(Order),typeof(HomeDetailControl),new PropertyMetadata(null));

        public HomeDetailControl()
        {
            InitializeComponent();
        }
    }
}
