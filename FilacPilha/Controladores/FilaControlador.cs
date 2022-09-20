using filaCircular.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Controladores
{
    public class FilaControlador : IFilaServico
    {
        private PilhaControlador pilha = new PilhaControlador();
        private PilhaControlador pilhaInvertida = new PilhaControlador();
        //private int[] elementos;
        public FilaControlador()
        {
        }
        
        public void inserir(int? elemento)
        {
            if(elemento != null)
            {
                transferir(pilhaInvertida, pilha);
                pilha.empilha(Convert.ToInt32(elemento));
            }
            
        }
        public object remover()
        {
            transferir(pilha, pilhaInvertida);
            return pilhaInvertida.desempilha();
        }
        public bool vazio()
        {
            return (pilha.vazio()) && (pilhaInvertida.vazio());
        }

        public int?[] mostrar()
        {
            int?[] lista = pilha.mostrar();
            int?[] listaI = pilhaInvertida.mostrar();
            Console.WriteLine(lista);
            Console.WriteLine(listaI);
            return lista;
        }

        public void transferir(PilhaControlador de, PilhaControlador para)
        {
            while (!de.vazio())
            {
                para.empilha(de.desempilha());
            }
        }   
        
    }
}
