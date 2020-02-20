using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX20
{
    public abstract class Veiculo
    {
        /*
        Atributos:
       -string  descricao
       -double  capacidadeMaximaEmKg 
       -double  velocidadeAtualEmKM   (atributo apenas leitura) //apenas get
       -double  capacidadeCarregadaemKg  (atributo apenas leitura) //apenas get

       Métodos:
       -double Carregar (double peso)// -> gerar exceção (personalizada) 
           se exceder a capacidadeMaximaEmKg//.  
           Exibir em vídeo a capacidade informada após carregar.
       -double  Acelerar() ; // aumenta em 1 km a velocidade atual 
           do veículo e exibe no console a nova velocidade
       -double PagarPedagio(); // seu cálculo depende de características do 
           tipo de veículo. Todo veículo deve pagar pedágio.
           o método ToString()// deverá exibir todos os atributos da classe, 
           concatenados.

       Obs:  um veículo automotor  não deve ser instanciado. 
       Apenas os seus descendentes podem ser instanciados.

       */
        //variaveis
        string descricao = "";
        double capacidadeMaximaEmKg = 0;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double CapacidadeMaximaEmKg
        {
            get { return capacidadeMaximaEmKg; }
            set { capacidadeMaximaEmKg = value; }
        }
        //(Atributos apenas leitura) 
        //apenas get
        protected double velocidadeAtualEmKm = 0;
        public double VelocidadeAtualEmKM
        {
            get { return velocidadeAtualEmKm; }
        }
        protected double capacidadeCarregadaEmkg = 0;
        public double CapacidadeCarregadaemKg
        {
            get { return capacidadeCarregadaEmkg; }
        }
        //Métodos!!
        public virtual double Carregar(double peso)
        {
            if (capacidadeCarregadaEmkg + peso > capacidadeMaximaEmKg)
            {
                double excedido = (CapacidadeCarregadaemKg + peso) - capacidadeMaximaEmKg;
                throw new CapacidadeMaximaExcedidaException(excedido);
            }
            else
                capacidadeCarregadaEmkg += peso;

            Console.WriteLine("Carregado {0}",capacidadeCarregadaEmkg);
            return CapacidadeCarregadaemKg;
        }
        // -> gerar exceção (personalizada) 
        //se exceder a capacidadeMaximaEmKg//.  

        public virtual void Acelerar()
        {
            velocidadeAtualEmKm++;
            Console.WriteLine(velocidadeAtualEmKm);
        }
        // aumenta em 1 km a velocidade atual 
        //do veículo e exibe no console a nova velocidade
        public abstract double PagarPedagio();
        // seu cálculo depende de características do 
        //tipo de veículo.Todo veículo deve pagar pedágio.

        //o método ToString()// deverá exibir todos os atributos da classe, 
        //concatenados.
        public override string ToString()
        {
            return "Descrição: " + Descricao + Environment.NewLine +
                   "Capacidade Máxima em Kg: " + CapacidadeMaximaEmKg + Environment.NewLine +
                   "Velocidade Atual em Km " + VelocidadeAtualEmKM + Environment.NewLine +
                   "Capacidade Carregada em Kg: " + CapacidadeCarregadaemKg;
           
        }

    }
}
