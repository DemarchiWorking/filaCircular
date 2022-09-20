using filaCircular.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Controladores
{
    public class PilhaControlador : IPilhaServico
    {

        private int?[] elementos;

        public PilhaControlador()
        {
            
        }
        public void empilha(int? elemento)
        {
            /*if (elementos == null)
            {
                elementos = new int?[] { };
            }*/

            elementos = new int?[] { null };
            if (elementos[0] == null)
            {
                elementos[0] = elemento;
            }
            else
            {
                elementos[elementos.Count()-1] = elemento;
            }

            //elementos.Append(Convert.ToInt32(elemento));
        }
        public int? desempilha()
        {
            int? inicial = null;
            if (elementos.Count() > 0)
            {
                Console.WriteLine(elementos[elementos.Count() - 1]);
                elementos[elementos.Count() - 1] = 0;
            }
            else
            {
                Console.WriteLine("Vazio!");
            }
            return inicial;
        }
        public bool vazio()
        {
            if(elementos == null)
            {
                return true;
            }
            else if (elementos.Count() == 0)
            {
                return elementos.Count() == 0;
            }
            else
            {
                return false;
            }
            

                //len(self.elementos) == 0
            /*if (elementos.Count() == 0)
            {
                return true;
            }*/
        }
        public int?[] mostrar()
        {
            int?[] t = elementos;
            Console.WriteLine(t);
            return t;
        }
    }
}
