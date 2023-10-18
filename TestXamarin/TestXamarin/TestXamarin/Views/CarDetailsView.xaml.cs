using TestXamarin.ViewModels;
using Xamarin.Forms;

namespace TestXamarin.Views
{
    [QueryProperty(nameof(CarIdParameter), nameof(CarIdParameter))]
    
    public partial class CarDetailsView : ContentPage
    {

   
        public string CarIdParameter
        {
            set
            {
                BindingContext = new CarDetailsViewModel(int.Parse(value));
            }
        }
        public CarDetailsView()
        {
            InitializeComponent();
        }
    }
}