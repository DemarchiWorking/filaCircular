using filaCircular.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Controladores
{
    public class FilaCircularControlador : IFilaServico
    {
        private int cabeca, calda;
        private Object[] elementos;
        private int total;

        public FilaCircularControlador()
        {
            total = 0;
            cabeca = -1;
            calda = -1;
            elementos = new Object[10];
        }
        public FilaCircularControlador(int tamanho)
        {
            total = 0;
            cabeca = -1;
            calda = -1;
            elementos = new Object[tamanho];
        }
        public void enqueue(int elemento)
        {
            if (!listaSobrecarregada())
            {
                if (calda == elementos.Length - 1)
                {
                    calda = -1;
                }
                total++;
                calda++;
                elementos[calda] = elemento;
            }else
            {
                Console.WriteLine("Fila Lotada.");
            }
        }
        public object dequeue()
        {
            Object inicial = null;
            if (!listaVazia())
            {
                if (cabeca == elementos.Length - 1)
                {
                    cabeca = -1;
                }
                total--;
                cabeca++;
                inicial = elementos[cabeca];
                Console.WriteLine(inicial);
                elementos[cabeca] = null;

            }
            else
            {
                Console.WriteLine("Fila Vazia!");
            }
            return inicial;
        }
        public Object mostrar()
        {
            Object inicial = null;
            int varAux = cabeca;

            if (!listaVazia())
            {
                if (varAux == elementos.Length - 1)
                {
                        varAux = -1;
                }
                inicial = elementos[varAux+1];

                for (int i = 0; i < elementos.Length; i++)
                {
                    Console.WriteLine(elementos[i]);
                }
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
            return elementos;
        }
        public void apagar()
        {
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = null;
            }
            
        }
        public bool listaSobrecarregada()
        {
            return (total == elementos.Count());
        }

        public bool listaVazia()
        {
            return (total == 0);
        }
        
    }
}
