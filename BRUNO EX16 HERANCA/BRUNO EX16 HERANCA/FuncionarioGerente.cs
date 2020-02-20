using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX16_HERANCA
{
    class FuncionarioGerente : Funcionario
    {
        public double Bonus { get; set; }
        public int QtdeFuncSubordinados { get; set; }

        public override string ToString()
        {
            return base.ToString() + " - Bonus: " + Bonus + " - Qtde Subordinados: " +
                QtdeFuncSubordinados;
        }
    }
}
