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
        public PilhaControlador pilha = new PilhaControlador();
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

        public List<int> mostrar()
        {

            Console.WriteLine("Pilha:");
            for (int i = 0; i < pilha.elementos.Count(); i++)
            {
                Console.WriteLine(pilha.elementos[i]);
            }            
            Console.WriteLine("Pilha Invertida:");
            for (int i = 0; i < pilhaInvertida.elementos.Count(); i++)
            {
                Console.WriteLine(pilhaInvertida.elementos[i]);
            }

            return pilhaInvertida.elementos;
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
