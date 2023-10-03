// See https://aka.ms/new-console-template for more information

var singletonTest = Singleton.Instance();
Console.WriteLine(singletonTest.mensaje);
singletonTest.mensaje = "Mi mensaje personalizado";
Console.WriteLine(singletonTest.mensaje);
