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
    class Dado
    {
        private int valorDado;

        public Dado(int valor)
        {
            this.valorDado = valor;
        }

        public int elDado()
        {
            return this.valorDado;
        }
        public void imprimir()
        {
            Console.WriteLine("numero dado: "+this.valorDado);
        }
    }
}
