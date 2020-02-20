using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX17_ABSTRACT
{
    class ContaCorrente : ContaBancaria
    {
        /*
        ContaCorrente: ContaBancaria

        Atributos:
        •	Double Limite de crédito
        •	Bool UtilizaTalaoCheque
        Métodos:
        •	void Saque(double valor);   - 
        O saldo + limite de crédito não pode ser < 0

        */
        private double limite;
        public double LimiteCredito
        {
            get
            {
                //return (Saldo < 0 ? limite + Saldo : limite);

                if (Saldo < 0)
                    return limite + Saldo;
                else
                    return limite;
            }

            set
            {
                limite = value;
            }
        }
        public bool UtilizaCheque { get; set; }
        public override void Saque(double valor)
        {
            if (Saldo + LimiteCredito < 0)
                throw new Exception("Saldo insuficiente");
            else
                Saldo -= valor;
        }
        public override string ToString()
        {
            return base.ToString() + $"- Limite de Credito: {LimiteCredito:c2} Utiliza cheque: {(UtilizaCheque ? "sim" : "não")}";
        }
    }
}
