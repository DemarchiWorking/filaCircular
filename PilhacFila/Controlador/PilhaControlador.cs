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

		public Object[] elementos;
		public int pont;
		public PilhaControlador()
		{
			this.pont = -1;
			this.elementos = new Object[99];// 52 posicoes
		}

		public bool isEmpty()
		{
			if (this.pont == -1)
			{
				return true;
			}
			return false;
		}

		public int tamanho()
		{
			if (this.isEmpty())
			{
				return 0;
			}
			return this.pont + 1;
		}

		public Object ultimoLista()
		{
			if (isEmpty())
			{
				return null;
			}
			return this.elementos[this.pont];
		}

		public Object desempilhar()
		{
			if (isEmpty())
			{
				return null;
			}
			return this.elementos[this.pont--];
		}

		public void adicionar(Object elemento)
		{
			if (this.pont < this.elementos.Length - 1)
			{
				this.elementos[++pont] = elemento;
			}
		}
	}

}
