using System.Collections.ObjectModel;

using Test1.Helpers;
using Test1.Models;
using Test1.Services;

namespace Test1.ViewModels
{
    public class Test3ViewModel : Observable
    {
        public ObservableCollection<Order> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
