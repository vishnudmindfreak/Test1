using System;

using Test1.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Test1.Views
{
    public sealed partial class Test3Page : Page
    {
        public Test3ViewModel ViewModel { get; } = new Test3ViewModel();
        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public Test3Page()
        {
            InitializeComponent();
        }
    }
}
