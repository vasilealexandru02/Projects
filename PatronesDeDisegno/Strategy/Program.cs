// See https://aka.ms/new-console-template for more information
// Patron de comportamiento/ funcionamiento strategy

using Strategy;
using Strategy.Coches;
using System;
using System.Numerics;


List<ICar> cars = new List<ICar>()
{
    new NissanSkyline(),
    new LamborghiniAventador(),
    new AstonMartinVanquish(),

};

while (true)
{
    Console.WriteLine("Choose one of the following cars: ");
    int counter = 1;
    foreach (var c in cars)
    {
        Console.WriteLine(counter + " - " + c.GetType().Name);
        counter++;
    }
    var option = int.Parse(Console.ReadLine()) - 1;

    CarContext car = new CarContext(cars[option]);
    car.Motor();
}






