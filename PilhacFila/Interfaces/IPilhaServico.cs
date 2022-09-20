using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Interfaces
{
    public interface IPilhaServico
    {
		int tamanho();

		Object ultimoLista();

		bool isEmpty();
		Object desempilhar();
		void adicionar(Object elemento);

	}
}
