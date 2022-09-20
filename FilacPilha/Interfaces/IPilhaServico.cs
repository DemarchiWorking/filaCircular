using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Interfaces
{
    public interface IPilhaServico
    {
        void empilha(int? elemento);
        int? desempilha();
        bool vazio();
        int?[] mostrar();
    }
}
