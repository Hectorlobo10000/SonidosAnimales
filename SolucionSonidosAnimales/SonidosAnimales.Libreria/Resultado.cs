using System;

namespace SonidosAnimales.Libreria
{
    public class Resultado
    {
        public static void ObtenerSonido(ISonidos fabrica, string animal)
        {
            var sonido = fabrica.Sonidos(animal);
            if (sonido == "Error!")
            {
                Console.WriteLine("Dice: " + sonido);
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Dice: " + sonido);
            }
        }
    }
}