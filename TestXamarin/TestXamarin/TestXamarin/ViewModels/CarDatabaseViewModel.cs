using MvvmHelpers;
using MvvmHelpers.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXamarin.Models;
using TestXamarin.Services;

namespace TestXamarin.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class CarDatabaseViewModel : BaseViewModel
    {
        public List<Car> Cars { get; set; }

        public AsyncCommand RefreshCommand { get; set; }

        public AsyncCommand ClearLastCar { get; set; }


        public CarDatabaseViewModel()
        {
            Cars = new List<Car>();
            RefreshCommand = new AsyncCommand(refresh);
            ClearLastCar = new AsyncCommand(clearCar);
            Initialize();

        }

        private async void Initialize()
        {
            await getCars();
        }


        public async Task getCars()
        {
            Cars = await CarServices.GetCar();
            // method that get car
        }

        public Task deleteCar()
        {
            return null;

            // method that deletes car 

        }

        private async Task clearCar()
        {
            await CarServices.RemoveCar(Cars.Last().Id);
        }

        private async Task refresh()
        {
            IsBusy = true;
            await CarServices.AddCar("Subaru", "XYZ-1023");
            await getCars();

            IsBusy = false;


        }



    }
}
