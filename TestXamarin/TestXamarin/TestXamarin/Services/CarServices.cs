using SQLite;
using System.Collections.Generic;
using System.IO;
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
            var image = "https://media.istockphoto.com/id/1273534607/vector/car-icon-auto-vehicle-isolated-transport-icons-automobile-silhouette-front-view-sedan-car.jpg?s=612x612&w=0&k=20&c=hpl9DfPNZ4EquzqsiVPmq1828pkFv0KkdkesxKdLk2Y=";
            var car = new Car
            {
                CarName = carName,
                CarImage = image,
                CarPlateNumber = carPlateNumber
            };

            var id = await db.InsertAsync(car);
        }
        public static async Task AddCar(string image, string carName, string carPlateNumber)
        {
            await Init();
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

        public static async Task<List<Car>> GetCar()
        {
            await Init();

            var cars = await db.Table<Car>().ToListAsync();

            return cars;
        }
    }
}
