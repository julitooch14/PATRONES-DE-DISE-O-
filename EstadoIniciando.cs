
using PatronesDiseno;

namespace PatronesDiseno;

public class EstadoIniciando : IEstadoServidor
{
    public void ManejarSolicitud(ServidorServicio servidor)
    {
        servidor.Estado = new EstadoActivo();
    }
}