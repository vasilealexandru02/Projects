using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Models
{

    [AddINotifyPropertyChangedInterface]
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CarImage { get; set; }
        public string CarName { get; set; }
        public string CarPlateNumber { get; set; }
        public bool IsFavorited { get; set; }
        
    }
}
