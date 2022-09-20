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

        public List<int> elementos;

        public PilhaControlador()
        {
            elementos = new List<int>();
        }
        public void empilha(int elemento)
        {
            elementos.Add(elemento);
        }
        public int desempilha()
        {
            int inicial = 0;
            if (elementos.Count() > 0)
            {
                inicial = elementos[elementos.Count() - 1];
                elementos.RemoveAt(elementos.Count() - 1);
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
        public List<int> mostrar()
        {
            List<int>  t = elementos;
            Console.WriteLine(t);
            return t;
        }

    
    }
}
