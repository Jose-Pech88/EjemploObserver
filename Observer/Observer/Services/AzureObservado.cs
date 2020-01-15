using Observer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.Services
{
    public class AzureObservado : IAzureObservado
    {
        public string cNombreCambio { get; set; }

        public string cComentario { get; set; }

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IAzureObservador> _observers = new List<IAzureObservador>();

        public AzureObservado(IAzureObservador _notificador)
        {
            this._observers.Add(_notificador);
        }

        // The subscription management methods.
        public void Attach(IAzureObservador observer)
        {
            Console.WriteLine("Se añade observador.");
            this._observers.Add(observer);
        }

        public void Detach(IAzureObservador observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Se remueve observador.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Ejecutando observador");

            foreach (var observer in _observers)
            {
                observer.EjecutarAccion(this);
            }
        }

        public void EjecutarOperacion()
        {

            Thread.Sleep(15);

            Console.WriteLine("El archivo se ha subido correctamente!!!.");
            this.Notify();
        }
    }
}
