using MvvmHelpers;
using MvvmHelpers.Commands;
using PropertyChanged;
using System.Threading.Tasks;
using TestXamarin.Models;
using TestXamarin.Services;
using TestXamarin.Views;
using Xamarin.Forms;

namespace TestXamarin.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CarDetailsViewModel : BaseViewModel
    {

        public int CarIdParameter { get; set; }

        public Car CarToShow { get; set; }

        public AsyncCommand GoBackCommand { get; set; }

        public CarDetailsViewModel(int carIdParameter)
        {

            CarIdParameter = carIdParameter;
            Initialize();

        }


        public async void Initialize()
        {
            GoBackCommand = new AsyncCommand(goBack);
            CarToShow = await CarServices.GetCarById(CarIdParameter);
        }

        public async Task goBack()
        {
            await Shell.Current.GoToAsync("//CarDatabaseView", false);
            //await Shell.Current.Navigation.PopModalAsync()

        }

    }
}
