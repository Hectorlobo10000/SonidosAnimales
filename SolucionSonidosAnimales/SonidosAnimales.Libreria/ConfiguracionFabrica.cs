using System;
using System.IO;

namespace SonidosAnimales.Libreria
{
    public class ConfiguracionFabrica
    {
        public static ISonidos ObtenerFabrica(string animal)
        {
            if (animal == "gato")
            {
                return new SonidoGato();
            }
            else if (animal == "perro")
            {
                return new SonidoPerro();
            }
            else if (animal == "gallo")
            {
                return new SonidoGallo();
            }
            else if (animal == "cerdo")
            {
                return new SonidoCerdo();
            }
            else
            {
                return new SonidoError();
            }
        }
    }
}