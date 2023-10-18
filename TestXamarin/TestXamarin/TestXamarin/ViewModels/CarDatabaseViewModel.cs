using MvvmHelpers;
using MvvmHelpers.Commands;
using PropertyChanged;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestXamarin.Models;
using TestXamarin.Services;
using TestXamarin.Views;
using Xamarin.Forms;

namespace TestXamarin.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class CarDatabaseViewModel : BaseViewModel
    {
        private Car selectedCar;
        //private Car previousSelectedCar;


        public List<Car> Cars
        { get; set; }

        public AsyncCommand RefreshCommand { get; set; }
        public AsyncCommand DeleteSelectedCar { get; set; }
        public AsyncCommand AddCar { get; set; }

        public AsyncCommand SeeCarDetails { get; set; }

        public Car SelectedCar
        {
            get => selectedCar;
            set
            {
                selectedCar = null;
                PreviousSelectedCar = value;

            }
        }

        public Car PreviousSelectedCar { get; set; }

        public CarDatabaseViewModel()
        {
            Cars = new List<Car>();
            RefreshCommand = new AsyncCommand(refresh);
            AddCar = new AsyncCommand(addCar);
            DeleteSelectedCar = new AsyncCommand(deleteSelectedCar);
            SeeCarDetails = new AsyncCommand(seeCarDetails);
            Initialize();

        }

        private async void Initialize()
        {
            await getCars();
        }


        public async Task getCars()
        {
            Cars = await CarServices.GetCars();
            // method that get car
        }

        public Task deleteCar()
        {
            return null;

            // method that deletes car 

        }

        private async Task deleteSelectedCar()
        {
            if (SelectedCar != null)
            {
                await CarServices.RemoveCar(SelectedCar.Id);
                await Application.Current.MainPage.DisplayAlert("Deleted", "Car " + SelectedCar.CarName + " was deleted succesfully", "OK");
                await getCars();
                SelectedCar = null;
            }
            else if (Cars.Count == 1)
            {
                await Application.Current.MainPage.DisplayAlert("Unable to delete car", "Cannot delete last car of the list!", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Select a car", "You must select a car first!", "OK");
            }
        }


        /// <summary>
        /// Refreshes the list view
        /// </summary>
        /// <returns></returns>
        private async Task refresh()
        {
            IsBusy = true;
            await getCars();
            IsBusy = false;
        }


        /// <summary>
        /// Adds a new car 
        /// </summary>
        /// <returns></returns>
        private async Task addCar()
        {
            string carImage = await Application.Current.MainPage.DisplayPromptAsync("Car image", "Introduce an image URL for your new car");


            string carName = await Application.Current.MainPage.DisplayPromptAsync("Car name", "Introduce your new car name");
            string carPlateNumber = await Application.Current.MainPage.DisplayPromptAsync("Car image", "Introduce the plate number for your car");

            if (carImage == string.Empty && (carName != null && carPlateNumber != null))
            {
                await CarServices.AddCar(carName, carPlateNumber);
            }
            else if (carImage != string.Empty && (carName != null && carPlateNumber != null))
            {
                await CarServices.AddCar(carImage, carName, carPlateNumber);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Couldn't create you car :(", "OK");
            }

            await getCars();

        }

        public async Task seeCarDetails()
        {
            await Shell.Current.GoToAsync($"{nameof(CarDetailsView)}?CarIdParameter={PreviousSelectedCar.Id}");

        }



    }
}
