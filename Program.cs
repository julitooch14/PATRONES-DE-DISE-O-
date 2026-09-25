using PatronesDiseno;

var servidorBase = new ServidorServicio("Servidor-Web-Base");
servidorBase.MostrarInformacion();

servidorBase.EjecutarAccion();
Console.WriteLine("--> Se ejecutó una acción en el servidor base.");
servidorBase.MostrarInformacion();

Console.WriteLine("\n--- Clonando Servidor ---");
var servidorClonado = servidorBase.Clonar();
servidorClonado.Nombre = "Servidor-Web-02";
servidorClonado.PuertosAbiertos.Add("8080");

servidorClonado.MostrarInformacion();
servidorClonado.EjecutarAccion();
Console.WriteLine("--> Se ejecutó una acción en el servidor clonado.");
servidorClonado.MostrarInformacion();