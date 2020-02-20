using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX10_OBJ
{
    class ContaCorrente
    {
        private int agencia;
        private string numconta;
        private string titular;
        private double saldo;

        public ContaCorrente(int agen, string numcont,
            string titul)
        {
            saldo = 0;
            Agencia = agen;
            NumConta = numcont;
            Titular = titul;
        }
        //public ContaCorrente(double valor)
        //{
        //    saldo = valor;
        //}
        public int Agencia
        {
            get => agencia;
            set
            {
                if (value <= 0)
                    throw new Exception("Não pode ser negativo");
                agencia = value;
            }
        }
        public string NumConta
        {
            get
            {
                return numconta;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Digite numero da conta");
                else
                    numconta = value;
            }
        }
        public string Titular
        {
            get
            {
                return titular;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Digite o nome do titular");
                else
                    titular = value;
            }
        }
        public double Saldo
        {
            get => saldo;
        }

        public void Saque(double sacar)
        {

            if (saldo - sacar < 0)
                throw new Exception("Saldo insuficiente!!!");
            else
                saldo -= sacar;


        }
        public void Deposito(double deposit)
        {
            saldo = saldo + deposit;
        }
       

    }
}
