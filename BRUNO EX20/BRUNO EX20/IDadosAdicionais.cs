using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX20
{
    public interface IDadosAdicionais
    {
        int VelocidadeLimpador { get; set; }
        void AcionarLimpador();
        void AbrirPorta();

    }
}
