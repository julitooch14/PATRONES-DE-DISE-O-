namespace PatronesDiseno;

public class ServidorServicio
{
    public string Nombre { get; set; }
    public List<string> PuertosAbiertos { get; set; }
    public IEstadoServidor Estado { get; set; }

    public ServidorServicio(string nombre)
    {
        Nombre = nombre;
        PuertosAbiertos = ["80", "443"];
        Estado = new EstadoApagado();
    }

    public void EjecutarAccion()
    {
        Estado.ManejarSolicitud(this);
    }

    public ServidorServicio Clonar()
    {
        var clon = (ServidorServicio)this.MemberwiseClone();
        clon.PuertosAbiertos = [.. this.PuertosAbiertos];
        clon.Estado = new EstadoApagado();
        return clon;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"[Servidor: {Nombre}] - Estado: {Estado.GetType().Name} - Puertos: {string.Join(", ", PuertosAbiertos)}");
    }
}