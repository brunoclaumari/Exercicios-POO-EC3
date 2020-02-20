using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX20
{
    class Carro : Veiculo, IDadosAdicionais
    {
        /*
            Atributos:
            int quantidade de portas.  
            bool UtilizandoReboque ;
            Métodos:
            O método ToString deve refletir todos os atributos da classe.
            No método de cálculo do pedágio: caso esteja usando reboque cobrar R$ 10,00. 
            Caso contrário, cobrar R$7,00. Exibir o valor pago em vídeo.
        */
        public int QtdePortas { get; set; } = 2;
        public bool UtilizaReboque { get; set; }

        int velocidadeLimpador;
        public int VelocidadeLimpador
        {
            get => velocidadeLimpador;
            set => velocidadeLimpador = value;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                        "Quantidade de Portas: " + QtdePortas + Environment.NewLine +
                        "Utiliza Reboque: " + (UtilizaReboque == true ? "Sim" : "Não");
        }

        public void AcionarLimpador()
        {
            if (VelocidadeLimpador == 1)
                Console.WriteLine(Descricao + ": TU....tá TU....tá TU....tá");
            else
                Console.WriteLine(Descricao + ": TU tá. TU tá. TU tá.");
        }

        public void AbrirPorta()
        {
            Console.WriteLine(Descricao+" RUAAAAAR!!!");
        }

        public override double PagarPedagio()
        {
            if (UtilizaReboque)
            {
                Console.WriteLine($"Pagou {10:c2} reais!");
                return 10;
            }
            else
            {
                Console.WriteLine($"Pagou {7:c2} reais!");
                return 7;
            }
                
        }
    }
}
