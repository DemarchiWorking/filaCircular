using filaCircular.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular.Interfaces
{
    public interface IFilaServico
    {
        void inserir(int? elemento);
        object remover();
        bool vazio();
        void transferir(PilhaControlador de, PilhaControlador para);
    }
}
