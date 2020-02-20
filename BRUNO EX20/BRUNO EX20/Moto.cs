using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX20
{
    public class Moto:Veiculo
    {
        /*         
        Atributos:
        int cilindradas
        Métodos
        string Empinar() -> exibe no console "Empinando...";
        O método ToString deve refletir todos os atributos da classe.
        Cálculo do pedágio: Para moto, considerar o valor R$ 2,00. 
        Exibir o valor pago em vídeo
         */
        
        public int Cilindradas { get; set; }

        public Moto()
        {
        }
        public string Empinar()
        {
            string emp = "Empinando...";
            return emp;
        }

        public override double PagarPedagio()
        {
            Console.WriteLine($"Pagou {2:c2} reais!");
            return 2;           
        }
        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine +
                "cilindradas: " + Cilindradas; ;
        }
    }
}
