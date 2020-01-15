using Observer.Services.Interface;
using System;

namespace Observer.Services
{
    public class Publicador : IAzureObservador
    {
        public void EjecutarAccion(IAzureObservado _azureObservado)
        {
            Console.WriteLine(string.Format("Se ha publicado el cambio {0}, con comentario {1}", _azureObservado.cNombreCambio, _azureObservado.cComentario));
        }
    }
}
