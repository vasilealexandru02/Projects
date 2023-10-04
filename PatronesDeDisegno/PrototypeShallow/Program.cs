// See https://aka.ms/new-console-template for more information

using PrototypeShallow;

Animal animal = new Animal()
{
    Nombre = "Oveja",
    Patas = 4
};
// En este caso si lo dejamos así, lo que está haciendo es tener como referencia el primer objeto.


//Animal animalClonado = animal;
// Al clonarlo, sí que se están tratanto dos objetos

Animal animalClonado = animal.Clone() as Animal;

// Si modifico este segundo objeto asignándole 5 patas, en realidad estoy modificando el primero, porque es la misma posición de memoria
animalClonado.Patas = 5;

Console.WriteLine("Nº de patas animal original: " + animal.Patas);
Console.WriteLine("Nº de patas animal clonado: " + animalClonado.Patas);

