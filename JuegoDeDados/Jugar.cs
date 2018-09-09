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
    class Jugar
    {
        private Dado dado1;
        private Dado dado2;
        private Dado dado3;

        public Jugar()
        {
            Random ValorDado1 = new Random();
            int nDado1 = ValorDado1.Next(1, 6);
            this.dado1 = new Dado(nDado1);

            int nDado2 = ValorDado1.Next(1, 6);
            this.dado2 = new Dado(nDado2);

            int nDado3 = ValorDado1.Next(1, 6);
            this.dado3 = new Dado(nDado3);
        }

        public void jugar()
        {
            dado1.imprimir();
            dado2.imprimir();
            dado3.imprimir();
            if (dado1.elDado() == dado2.elDado() && dado1.elDado() == dado3.elDado())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n  Ganaste!!\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n  Perdiste!!\n");
            }
        }
    }
}
