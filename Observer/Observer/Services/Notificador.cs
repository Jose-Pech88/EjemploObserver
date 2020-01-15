using Observer.Services.Interface;
using System;

namespace Observer.Services
{
    public class Notificador : IAzureObservador
    {
        public void EjecutarAccion(IAzureObservado _azureObservado)
        {
            Console.WriteLine(string.Format("Se ha notificado al usuario por el cambio {0}, con comentario {1}", _azureObservado.cNombreCambio, _azureObservado.cComentario));
        }
    }
}
