using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX16_HERANCA
{
    class FuncionarioVendedor : Funcionario
    {
        /*
            •	Double MetaDeVendaMesEmReais 
            •	Double VendasdoMesEmReais    
            •	Double PorcentagemSobreVendas (para incorporar no salário). 
            Exemplo: 10%, deve-se calcular 10% sobre o campo    
            VendasdoMesEmReais e incorporar ao salário durante o cálculo.
         */

        public double MetasDeVendasMes { get; set; }

        public double VendasDoMesEmReais { get; set; }

        public double PorcentagemSobreVendas { get; set; }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + (VendasDoMesEmReais * (PorcentagemSobreVendas / 100));
        }

        public override string ToString()
        {
            return base.ToString() + "  Meta: " + MetasDeVendasMes +
                " Total de vendas no mês: " + VendasDoMesEmReais +
                " % sobre as vendas: " + PorcentagemSobreVendas;
        }
    }
}
