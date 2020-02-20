using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX20
{
    public class Caminhao : Veiculo, IDadosAdicionais
    {
        /*
        
        Atributos:
        int QuantidadeEixos;

        Métodos
        double Carregar(double peso) -> exibe no console "Carregado". 
        Caso o peso ultrapasse o peso máximo,  NÃO gere uma exceção, 
        mas exiba em vídeo a mensagem “Sobrecarregado”;
        O método Acelerar não deve acelerar 
        o caminhão caso o peso carregado no 
        caminhão ultrapasse o peso máximo. Neste caso, gere uma exceção com o texto “Sobrecarregado!”.
        O método ToString deve refletir todos os atributos da classe.

        Crie o método  Descarregar() , que irá retirar todo o peso 
        e escrever "Vazio" no console;
        Cálculo do pedágio: Considerar o valor R$ 5,00 por eixo. 
        Exibir o valor pago em vídeo.
 
        */

        public int QuantEixos { get; set; } = 2;
        public Caminhao()
        {
            QuantEixos = 2;
        }
        int velocidadeLimpador;
        public int VelocidadeLimpador
        {
            get => velocidadeLimpador;
            set => velocidadeLimpador = value;
        }

        public override double Carregar(double peso)
        {
            capacidadeCarregadaEmkg += peso;
            if (capacidadeCarregadaEmkg + peso > CapacidadeMaximaEmKg)
            {
                Console.WriteLine("Sobregarregado");
            }
            else
                Console.WriteLine("Carregado");
            return CapacidadeCarregadaemKg;
        }
        public override void Acelerar()
        {
            if (capacidadeCarregadaEmkg <= CapacidadeMaximaEmKg)
                base.Acelerar();
            else
                throw new CapacidadeMaximaExcedidaException();
        }
        public void Descarregar()
        {
            capacidadeCarregadaEmkg = 0;
            Console.WriteLine("Vazio");
        }

        public void AbrirPorta()
        {
            Console.WriteLine(Descricao + "RUUARRR");
        }

        public void AcionarLimpador()
        {
            if (velocidadeLimpador == 1)
                Console.WriteLine(Descricao + ": TU.... TU.... TU....");
            else
                Console.WriteLine(Descricao + ": TU. TU. TU.");
        }

        public override double PagarPedagio()
        {
            return 5 * QuantEixos;
        }
    }
}
