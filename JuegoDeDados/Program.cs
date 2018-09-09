using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @Autor MarcoUrrutiaM
 */
namespace JuegoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //se le da color al fondo y al texto de la consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //titulo y tamano de la consola
            Console.Title = "DadosLocos";
            Console.WindowHeight =  15;//alto
            Console.WindowWidth =  31;//ancho
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            
            //crea una insatancia de juego
            Jugar juego = new Jugar();
            juego.jugar();
        }
    }
}
