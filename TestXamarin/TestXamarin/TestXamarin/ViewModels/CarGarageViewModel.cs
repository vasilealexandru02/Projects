using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Linq;
using System.Threading.Tasks;
using TestXamarin.Models;
using Xamarin.Forms;

namespace TestXamarin.ViewModels
{

    public class CarGarageViewModel : BaseViewModel
    {
        private ObservableRangeCollection<Car> _cars;

        private ObservableRangeCollection<Grouping<string, Car>> _carGroup;


        private Car _selectedCar;

        public MvvmHelpers.Commands.Command RefreshCommand { get; set; }


        public AsyncCommand<Car> FavoriteCommand { get; set; }

        public AsyncCommand<object> SelectedCommand { get; set; }


        public CarGarageViewModel()
        {
            IsBusy = false;
            Title = "Car Garage";
            Cars = new ObservableRangeCollection<Car>
{
    new Car { CarImage = "https://scene7.toyota.eu/is/image/toyotaeurope/Corolla-14:Small-Landscape?ts=0&resMode=sharp2&op_usm=1.75,0.3,2,0", CarName = "Toyota Corolla", CarPlateNumber = "ABC-123" },
    new Car { CarImage = "https://www.honda.es/content/dam/central/cars/civic-hybrid/overview-v3/Honda-civic-hybrid-01-1x1-mobile.jpg/_jcr_content/renditions/m_r.jpg", CarName = "Honda Civic", CarPlateNumber = "DEF-456" },
    new Car { CarImage = "https://www.ford.es/content/dam/guxeu/rhd/central/cars/2021-focus/launch/gallery/exterior/ford-focus-mca-c519-eu-STL_03_C519_Focus_Ext_Rear_3_4_Static-9x8-1200x1066_gt.jpg.renditions.original.png", CarName = "Ford Focus", CarPlateNumber = "GHI-789" },
    new Car { CarImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Chevrolet_Cruze_J300_sedan_China_2012-04-14.jpg/1200px-Chevrolet_Cruze_J300_sedan_China_2012-04-14.jpg", CarName = "Chevrolet Cruze", CarPlateNumber = "JKL-012" },
    new Car { CarImage = "https://hips.hearstapps.com/hmg-prod/images/elantra-n-03-1626252184.jpg?crop=1.00xw:1.00xh;0,0&resize=2048:*", CarName = "Hyundai Elantra", CarPlateNumber = "MNO-345" },
    new Car { CarImage = "https://media-assets.mazda.eu/image/upload/q_auto,f_auto/mazdaes/globalassets/cars/2024-mazda3-hatchback/showroom/230307_673_378_slidinggallerystatic_large_m3.jpg?rnd=498ba7", CarName = "Mazda 3", CarPlateNumber = "PQR-678" },
    new Car { CarImage = "https://hips.hearstapps.com/hmg-prod/images/volkswagen-golf-gti-clubsport-s-3-door-4-1608297130.jpeg", CarName = "Volkswagen Golf", CarPlateNumber = "STU-901" },
    new Car { CarImage = "https://cdn.motor1.com/images/mgl/2Xq6p/s1/low-mileage-1998-subaru-impreza-22b-sti.jpg", CarName = "Subaru Impreza", CarPlateNumber = "VWX-234" },
    new Car { CarImage = "https://static.motor.es/fotos-noticias/2021/10/kia-forte-2022-202181844-1633981579_1.jpg", CarName = "Kia Forte", CarPlateNumber = "YZA-567" },
    new Car { CarImage = "https://www.autonocion.com/wp-content/uploads/2019/11/Nissan-Sentra-2020-2.jpg", CarName = "Nissan Sentra", CarPlateNumber = "BCD-890" }
};

            CarGroup = new ObservableRangeCollection<Grouping<string, Car>>();
            CarGroup.Add(new Grouping<string, Car>("Car group 1", Cars.Take(2)));
            Cars.RemoveRange(Cars.Take(2));
            CarGroup.Add(new Grouping<string, Car>("Car group 1", Cars.Take(2)));

            FavoriteCommand = new AsyncCommand<Car>(Favorite);
            RefreshCommand = new MvvmHelpers.Commands.Command(refresh);
            SelectedCommand = new AsyncCommand<object>(Selected);
        }

        public ObservableRangeCollection<Car> Cars { get => _cars; set => _cars = value; }
        public ObservableRangeCollection<Grouping<string, Car>> CarGroup { get => _carGroup; set => _carGroup = value; }
        public Car SelectedCar
        {
            get => _selectedCar;
            set => SetProperty(ref _selectedCar, value);
        }


        /// <summary>
        /// Selected event to command
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        async Task Selected(object args)
        {

            Car car = args as Car;

            if (car == null) return;

            SelectedCar = null;

            await Application.Current.MainPage.DisplayAlert("Selected event: ", car.CarName, "OK");
        }
        async Task Favorite(Car car)
        {
            if (car.IsFavorited)
            {
                car.IsFavorited = false;
                await Application.Current.MainPage.DisplayAlert("Favorited!", "This car has been deleted from your favorite cars :(!", "OK");
            }
            else
            {
                car.IsFavorited = true;
                await Application.Current.MainPage.DisplayAlert("Favorited!", "This car has been added to your favorite cars!", "OK");
            }
        }

        private async void refresh()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }

    }
}
