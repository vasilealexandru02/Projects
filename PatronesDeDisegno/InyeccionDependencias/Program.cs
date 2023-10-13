// See https://aka.ms/new-console-template for more information

using InyeccionDependencias;
using InyeccionDependencias.WorkshopExample;

MediasDeSeda mediasDeSeda = new MediasDeSeda();
PinaColada pinaColada = new PinaColada();


Cantinero cantinero = new Cantinero(mediasDeSeda);
Cantinero cantinero2 = new Cantinero(pinaColada);

cantinero.Preparar();
cantinero2.Preparar();
Console.WriteLine("Hello, World!");


// Workshop example

IMechanic brushworkMechanic = new BrushworkMechanic("Daniel");

IMechanic wheelsMechanic = new WheelsMechanic("Sergio");

Workshop workshop = new Workshop(wheelsMechanic);

workshop.Work();


