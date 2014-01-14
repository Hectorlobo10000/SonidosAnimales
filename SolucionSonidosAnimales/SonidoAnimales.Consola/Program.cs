using System;
using SonidosAnimales.Libreria;

namespace SonidoAnimales.Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Animales : gato, perro, gallo, cerdo

            Console.WriteLine("Ingrese el nombre de uno de los siguientes animales: ");
            Console.WriteLine("1. Gato.");
            Console.WriteLine("2. Perro.");
            Console.WriteLine("3. Gallo.");
            Console.WriteLine("4. Cerdo.");
            Console.ForegroundColor = ConsoleColor.Red;
            string animal = Console.ReadLine();

            ISonidos fabrica = ConfiguracionFabrica.ObtenerFabrica(animal);

            Resultado.ObtenerSonido(fabrica, animal);

            Console.ReadKey();
        }
    }
}