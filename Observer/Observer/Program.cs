using Observer.Services;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var notificador = new Notificador();
            var uploadCode = new AzureObservado(notificador);
            uploadCode.cNombreCambio = "Versión 1";
            uploadCode.cComentario = "Subir archivo prueba";

            var compilador = new Compilador();
            uploadCode.Attach(compilador);

            var pruebas = new EjecutadorPruebasUnitarias();
            uploadCode.Attach(pruebas);

            var publicador = new Publicador();
            uploadCode.Attach(publicador);

            uploadCode.EjecutarOperacion();
            Console.ReadKey();
        }
    }
}
