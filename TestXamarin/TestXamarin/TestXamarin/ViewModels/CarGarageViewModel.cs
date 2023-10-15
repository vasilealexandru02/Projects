using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestXamarin.Models;

namespace TestXamarin.ViewModels
{
    public class CarGarageViewModel : BaseViewModel
    {
        private ObservableRangeCollection<Car> _cars;

        private ObservableRangeCollection<Grouping<string, Car>> _carGroup;

        public Command RefreshCommand { get; set; }


        public CarGarageViewModel()
        {
            IsBusy = false;
            Title = "Car Garage";
            Cars = new ObservableRangeCollection<Car>
            {
                new Car("https://scene7.toyota.eu/is/image/toyotaeurope/Corolla-14:Small-Landscape?ts=0&resMode=sharp2&op_usm=1.75,0.3,2,0", "Toyota Corolla", "ABC-123"),
                new Car("https://www.honda.es/content/dam/central/cars/civic-hybrid/overview-v3/Honda-civic-hybrid-01-1x1-mobile.jpg/_jcr_content/renditions/m_r.jpg", "Honda Civic", "DEF-456"),
                new Car("https://www.ford.es/content/dam/guxeu/rhd/central/cars/2021-focus/launch/gallery/exterior/ford-focus-mca-c519-eu-STL_03_C519_Focus_Ext_Rear_3_4_Static-9x8-1200x1066_gt.jpg.renditions.original.png", "Ford Focus", "GHI-789"),
                new Car("https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Chevrolet_Cruze_J300_sedan_China_2012-04-14.jpg/1200px-Chevrolet_Cruze_J300_sedan_China_2012-04-14.jpg", "Chevrolet Cruze", "JKL-012"),
                new Car("https://hips.hearstapps.com/hmg-prod/images/elantra-n-03-1626252184.jpg?crop=1.00xw:1.00xh;0,0&resize=2048:*", "Hyundai Elantra", "MNO-345"),
                new Car("https://media-assets.mazda.eu/image/upload/q_auto,f_auto/mazdaes/globalassets/cars/2024-mazda3-hatchback/showroom/230307_673_378_slidinggallerystatic_large_m3.jpg?rnd=498ba7", "Mazda 3", "PQR-678"),
                new Car("https://hips.hearstapps.com/hmg-prod/images/volkswagen-golf-gti-clubsport-s-3-door-4-1608297130.jpeg", "Volkswagen Golf", "STU-901"),
                new Car("https://cdn.motor1.com/images/mgl/2Xq6p/s1/low-mileage-1998-subaru-impreza-22b-sti.jpg", "Subaru Impreza", "VWX-234"),
                new Car("https://static.motor.es/fotos-noticias/2021/10/kia-forte-2022-202181844-1633981579_1.jpg", "Kia Forte", "YZA-567"),
                new Car("https://www.autonocion.com/wp-content/uploads/2019/11/Nissan-Sentra-2020-2.jpg", "Nissan Sentra", "BCD-890")
            };
            CarGroup = new ObservableRangeCollection<Grouping<string, Car>>();
            CarGroup.Add(new Grouping<string, Car>("Car group 1", Cars.Take(2)));
            Cars.RemoveRange(Cars.Take(2));
            CarGroup.Add(new Grouping<string, Car>("Car group 1", Cars.Take(2)));

            RefreshCommand = new Command(refresh);
        }

        public ObservableRangeCollection<Car> Cars { get => _cars; set => _cars = value; }
        public ObservableRangeCollection<Grouping<string, Car>> CarGroup { get => _carGroup; set => _carGroup = value; }

        private void refresh()
        {
            IsBusy = true;
            Task.Delay(10000);
            IsBusy = false;
        }

    }
}
