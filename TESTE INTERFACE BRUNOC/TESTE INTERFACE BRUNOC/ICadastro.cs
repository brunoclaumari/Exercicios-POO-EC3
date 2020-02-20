using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_INTERFACE_BRUNOC
{
    interface ICadastro
    {

        string Arquivo { get; set; }
        void Alterar(string dados);
        void Consultar(int codigo);
        void Excluir(string dados);
        void Incluir(string dados);
    }
}
