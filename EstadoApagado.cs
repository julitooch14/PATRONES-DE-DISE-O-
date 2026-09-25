using PatronesDiseno;

namespace PatronesDiseno;

public class EstadoApagado : IEstadoServidor
{
    public void ManejarSolicitud(ServidorServicio servidor)
    {
        servidor.Estado = new EstadoIniciando();
    }
}