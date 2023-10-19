using MvvmHelpers;
using MvvmHelpers.Commands;
using PropertyChanged;
using SQLite;
using System.Threading.Tasks;
using TestXamarin.Models;
using TestXamarin.Services;
using Xamarin.Forms;

namespace TestXamarin.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class AddCarViewModel : BaseViewModel
    {
        public string CarName { get; set; }

        public string CarPlateNumber { get; set; }

        public string CarImage { get; set; } = "https://imgs.search.brave.com/1XPubdx8xMlhaPxqNAmOVOSGdFyRvKRSojf2iFQps9c/rs:fit:860:0:0/g:ce/aHR0cHM6Ly91cGxv/YWQud2lraW1lZGlh/Lm9yZy93aWtpcGVk/aWEvY29tbW9ucy9l/L2VlL0xhbWJvcmdo/aW5pX1VydXNfMjAx/ODAzMDZfR2VuZl8y/MDE4LmpwZw";


        public AsyncCommand GoBackCommand { get; set; }

        public AsyncCommand SaveCarCommand { get; set; }


        #region Constructor
        public AddCarViewModel()
        {

            SaveCarCommand = new AsyncCommand(saveCar);
            GoBackCommand = new AsyncCommand(goBack);

        }


        #endregion

        public async Task goBack()
        {
            await Shell.Current.GoToAsync("//CarDatabaseView", false);
        }


        public async Task saveCar()
        {
            var car = new Car
            {
                CarName = CarName,
                CarPlateNumber = CarPlateNumber,
                CarImage = CarImage
            };
            await CarServices.AddCar(car);
            await Shell.Current.GoToAsync("//CarDatabaseView", false);

        }

    }
}
