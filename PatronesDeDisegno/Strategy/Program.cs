// See https://aka.ms/new-console-template for more information
// Patron de comportamiento/ funcionamiento strategy

using Strategy;
using Strategy.Coches;
using System;

//Random random = new Random();
//List<CarContext> coches = new List<CarContext>();
//coches.Add(new CarContext(CarContext.TiposCoche.NissanSkyline));
//coches.Add(new CarContext(CarContext.TiposCoche.LamborghiniAventador));
//coches.Add(new CarContext(CarContext.TiposCoche.AstonMartinVanquish));
CarContext car = new CarContext(new LamborghiniAventador());
car.Motor();
//elegirCoche();

//void elegirCoche()
//{
//    int numeroAleatorio = random.Next(0, coches.Count);
//    Console.WriteLine("El nº aleatorio que se ha generado es el siguiente: " + numeroAleatorio);
//    car = coches[numeroAleatorio];

//}





