using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_N1
{
    public class Fatura
    {
        int codigo;
        private int codItem;
        private string descr;
        private int qunati;
        private double preco;    

        public Fatura(int c, int i, int q, string d, double p)
        {
            Codigo = c;
            CodigoDoItem = i;
            Preco = p;
            Quantidade = q;
            Descrição = d;
        }
        
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {               
                if (value < 0 )
                   throw new Exception("Valor de código invalido");
                codigo = value;
            }
        }
        public int CodigoDoItem
        {
            get
            {
                return codItem;
            }
            set
            {
                if (codItem < 0)
                    throw new Exception("código do iten invalido");
                codItem = value;
            }
        }
        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
                if (preco < 0)
                    preco = 0;                
            }
        }
        public int Quantidade
        {
            get
            {
                return qunati;
            }
            set
            {
                qunati = value;
                if (qunati < 0)
                    qunati = 0;
                
            }
        }
        public string Descrição
        {
            get
            {
                return descr;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Descrição invalida invalido");
            }
        }
        public double TotalFatura()
        {
            double fatura = qunati * preco;
            return fatura;
        }

    }
}
