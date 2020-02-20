using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_N2_BRUNO_CORREÇÃO
{
    class CompraCartao
    {
        string produto;
        double valor;

        public string Produto
        {
            get => produto;
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Não pode vazio!!");
                else
                    produto = value;
            }
        }

        public double Valor
        {
            get => valor;
            set
            {
                if (value<0)
                    throw new Exception("Não pode negativo!!");
                else
                    valor = value;
            }
        }
        //Construtor Parametrizado
        public CompraCartao(string prod,double val)
        {
            Produto = prod;
            Valor = val;
        }
    }
}
