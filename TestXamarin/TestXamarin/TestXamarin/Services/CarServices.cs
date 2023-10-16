using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TestXamarin.Models;

namespace TestXamarin.Services
{
    class CarServices
    {


        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }
            // Get an absolute path to the database file
            var databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Car>();

        }

        public static async Task AddCar(string carName, string carPlateNumber)
        {
            await Init();
            var image = "https://scene7.toyota.eu/is/image/toyotaeurope/Corolla-14:Small-Landscape?ts=0&resMode=sharp2&op_usm=1.75,0.3,2,0";
            var car = new Car
            {
                CarName = carName,
                CarImage = image,
                CarPlateNumber = carPlateNumber
            };

            var id = await db.InsertAsync(car);
        }

        public static async Task RemoveCar(int carId)
        {
            await Init();

            await db.DeleteAsync<Car>(carId);
        }

        public static async Task<IEnumerable<Car>> GetCar()
        {
            await Init();

            var cars = await db.Table<Car>().ToListAsync();

            return cars;
        }
    }
}
