using filaCircular.Controladores;
using System;

namespace FilacPilha
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FilaControlador fila = new FilaControlador();
			PilhaControlador pilha = new PilhaControlador();
			int[] elementos;


		
			while (true)
			{
				Console.WriteLine("Fila com Pilha");
				Console.WriteLine("Selecione uma das opções abaixo:");
				Console.WriteLine(" 1 - Inserir");
				Console.WriteLine(" 2 - Remover");
				Console.WriteLine(" 3 - Mostrar");
				var resposta = Console.ReadLine();
				string opcao;
				switch (resposta)
				{
					case "1":
						Console.WriteLine("Digite o valor a ser adicionado na fila.");
						opcao = Console.ReadLine();
						Console.WriteLine("-------------------------");
						fila.inserir(Convert.ToInt32(opcao));
						break;
					case "2":
						Console.WriteLine("-------------------------");
						fila.remover();
						break;
					case "3":
						Console.WriteLine("-------------------------");
						Console.WriteLine(fila.mostrar()); 
						break;
					default:
						Console.WriteLine("Escolha uma opção válida");
						break;
				}
			}
		}
	}
}
