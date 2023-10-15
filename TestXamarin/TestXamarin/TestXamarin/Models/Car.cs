using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Models
{
    public class Car
    {
        private string _carImage;

        private string _carName;

        private string _carPlateNumber;

        public string CarImage { get => _carImage; set => _carImage = value; }
        public string CarName { get => _carName; set => _carName = value; }
        public string CarPlateNumber { get => _carPlateNumber; set => _carPlateNumber = value; }

        public Car(string carImage, string carName, string carPlateNumber)
        {
            CarImage = carImage;
            CarName = carName;
            CarPlateNumber = carPlateNumber;
        }
    }
}
