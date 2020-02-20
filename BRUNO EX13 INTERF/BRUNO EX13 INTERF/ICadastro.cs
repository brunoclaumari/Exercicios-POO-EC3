using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX13_INTERF
{
    interface ICadastro
    {
        void Salvar();

        String Pesquisar(string valor);

        int Codigo { get; set; }

        string Nome { get; set; }
    }
}
