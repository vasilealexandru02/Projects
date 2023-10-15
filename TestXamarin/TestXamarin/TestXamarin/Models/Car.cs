using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Models
{

    [AddINotifyPropertyChangedInterface]
    public class Car
    {
        public string CarImage { get; set; }
        public string CarName { get; set; }
        public string CarPlateNumber { get; set; }
        public bool IsFavorited { get; set; }

        public Car(string carImage, string carName, string carPlateNumber)
        {
            CarImage = carImage;
            CarName = carName;
            CarPlateNumber = carPlateNumber;
        }
    }
}
