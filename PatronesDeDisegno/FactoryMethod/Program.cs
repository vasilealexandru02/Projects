// See https://aka.ms/new-console-template for more information


using FactoryMethod;



Coche coche = Creador.CrearCoche(Creador.HYUNDAII30N);

// Lo que soluciona este patrón es la capacidad para crear objetos de forma transparente al usuario

// Es muy escalable, simplemente hay que agregar más constantes
Console.WriteLine("Caballaje : " + coche.Caballos());

