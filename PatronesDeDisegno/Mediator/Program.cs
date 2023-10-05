// See https://aka.ms/new-console-template for more information

// Este patrón de diseño sirve como intermediario entre varias clases que se comunican entre sí. Se suele utilizar en estos ámbitos para evitar problemáticas a la hroa de comunicación directa entre clases. La clase mediator es la que se encarga de ello
Mediator mediator = new Mediator();

Colleague alex = new User(mediator);

Colleague pepe = new UserAdmin(mediator);

Colleague peli = new UserAdmin(mediator);

mediator.AddColleague(pepe);
mediator.AddColleague(alex);
mediator.AddColleague(peli);


alex.Communicate("Hey admin I have a problem");

pepe.Communicate("Hey alex I'm sorry to hear that, how can I help you? :)");
peli.Communicate("Sorry to hear that Alex! Let's see how can we solve that!");

