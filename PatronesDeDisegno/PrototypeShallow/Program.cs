// See https://aka.ms/new-console-template for more information

using PrototypeShallow;

Animal animal = new Animal()
{
    Nombre = "Oveja primera",
    Patas = 4
};
// En este caso si lo dejamos así, lo que está haciendo es tener como referencia el primer objeto.

animal.Detalles = new Detalles();
animal.Detalles.Color = "Azul";
animal.Detalles.Raza = "Oveja marciana";
//Animal animalClonado = animal;
// Al clonarlo, sí que se están tratanto dos objetos

Animal animalClonado = animal.Clone() as Animal;
animalClonado.Detalles.Raza = "Oveja normal";
animalClonado.Nombre = "Oveja segunda";
// Si modifico este segundo objeto asignándole 5 patas, en realidad estoy modificando el primero, porque es la misma posición de memoria
animalClonado.Patas = 5;
Console.WriteLine("---Ejemplo con el clonado superficial/shallow---");
Console.WriteLine("Nº de patas animal original: " + animal.Patas);
Console.WriteLine("Nº de patas animal clonado: " + animalClonado.Patas);

Console.WriteLine("---Ejemplo con el clonado profundo/deep---");
Console.WriteLine("Raza del animal original: " + animal.Detalles.Raza);
Console.WriteLine("Nombre del animal original: " + animal.Nombre);
///////Lo que ocurre en el clonado superficial, es que el objeto de detalles del segundo objeto, es una referencia al objeto detalles del primero objeto animal. Por eso hay que realizar un clonado profundo
Console.WriteLine("Raza del animal clonado: " + animalClonado.Detalles.Raza);
Console.WriteLine("Nombre del animal clonado: " + animalClonado.Nombre);

