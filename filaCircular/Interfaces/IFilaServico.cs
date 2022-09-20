using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Interfaces
{
    public interface IFilaServico
    {
        void enqueue(int elemento);
        Object dequeue();
        Object mostrar();
        bool listaSobrecarregada();
        bool listaVazia();
        void apagar();
    }
}
