// See https://aka.ms/new-console-template for more information

// Este patrón de diseño sirve como intermediario entre varias clases que se comunican entre sí. Se suele utilizar en estos ámbitos para evitar problemáticas a la hora de comunicación directa entre clases. La clase mediator es la que se encarga de ello
Mediator mediator = new Mediator();

Colleague alex = new User(mediator, "alex");

Colleague pepe = new UserAdmin(mediator, "pepe");

Colleague peli = new UserAdmin(mediator, "peli");

mediator.AddColleague(pepe);
mediator.AddColleague(alex);
mediator.AddColleague(peli);


alex.Communicate("Hey admin I have a problem", false);

pepe.Communicate("Hey alex I'm sorry to hear that, how can I help you? :)", false);
peli.Communicate("Sorry to hear that Alex! Let's see how can we solve that!", false);

