using filaCircular.Controladores;
using filaCircular.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
			IFilaServico filaCircular = new FilaCircularControlador();
			while (true)
			{
				Console.WriteLine("Fila Circular");
				Console.WriteLine("Selecione uma das opções abaixo:");
				Console.WriteLine(" 1 - Adicionar");
				Console.WriteLine(" 2 - Remover");
				Console.WriteLine(" 3 - Mostrar");
				Console.WriteLine(" 4 - Limpar");
				var resposta = Console.ReadLine();
				Console.WriteLine(resposta);
				string opcao;
				switch (resposta)
				{
					case "1":
						Console.WriteLine("Digite o valor a ser adicionado na lista.");
						opcao = Console.ReadLine();
						Console.WriteLine("-------------------------");
						filaCircular.enqueue(Convert.ToInt32(opcao));
						break;
					case "2":
						Console.WriteLine("-------------------------");
						filaCircular.dequeue();
						break;
					case "3":
						Console.WriteLine("-------------------------");
						filaCircular.mostrar();
						break;
					case "4":
						Console.WriteLine("-------------------------");
						filaCircular.apagar();
						break;
					default:
						Console.WriteLine("Escolha uma opção válida");
						break;
				}
			}
		}
    }
}
