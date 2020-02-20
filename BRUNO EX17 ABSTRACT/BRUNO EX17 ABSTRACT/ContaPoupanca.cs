using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX17_ABSTRACT
{
    class ContaPoupanca:ContaBancaria
    {
        /*
        ContaPoupanca: ContaBancaria
        Atributos:
	    Int Dia de aniversário:
        string	Nº da c.Corrente atrelada
        Métodos:
	    void Saque(double valor);   - O saldo não pode ser < 0
         */
        public int DiaAniver { get; set; }
        public string NumCCAtrelada { get; set; }

        public override void Saque(double valor)
        {
            if (Saldo - valor < 0)
                throw new Exception("Saldo insuficiente!!");
            Saldo -= valor;
        }
        public override string ToString()
        {
            return base.ToString() + $"- Dia de Aniversario Poupança {DiaAniver}" +
                $" - CC Atrelada: {NumCCAtrelada}";
        }
    }
}
