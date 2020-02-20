using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX20
{
    public class CapacidadeMaximaExcedidaException : Exception
    {
        public CapacidadeMaximaExcedidaException(double pesoExcedido)
            : base("O peso foi excedido em "+ pesoExcedido +" kg")
        {
        }
        public CapacidadeMaximaExcedidaException()
            : base("Está Sobrecaregado e não pode acelerar!")
        {
            //File.WriteAllText("LogErro.TXT", mensagem + 
            //    " Número: " + numero + Environment.NewLine);
        }
    }
}
