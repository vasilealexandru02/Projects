// Este patrón de comportamiento trabaja con el "estado" de los objetos
// Proporciona un comportamiento diferente dependiendo del stado de nuestro objeto, en este caso, comportamientos diferentes en base al estado del servidor
// See https://aka.ms/new-console-template for more information


using State;

ServerContext server = new ServerContext();
server.State = new AvailableServerState();
server.AttendRequest();

server.State = new UnavailableState();
server.AttendRequest();


server.State = new OverloadedServerState();
server.AttendRequest(); 


server.State = new DownServerState();
server.AttendRequest();






