// See https://aka.ms/new-console-template for more information

// Es un algoritmo de creación, que utiliza una clase constructora para crear mis objetos.
using FactoryMethod;



Coche coche = Creador.CrearCoche(Creador.HYUNDAII30N);

Coche nissan = Creador.createNissan();
Coche hyundai = Creador.createHyundai();


// Lo que soluciona este patrón es la capacidad para crear objetos de forma transparente al usuario

// Es muy escalable, simplemente hay que agregar más constantes
Console.WriteLine("Caballaje : " + coche.Caballos());


Console.WriteLine(nissan.GetType().Name + ": " + nissan.Caballos() + " caballos");
Console.WriteLine(hyundai.GetType().Name + ": " + hyundai.Caballos() + " caballos");



