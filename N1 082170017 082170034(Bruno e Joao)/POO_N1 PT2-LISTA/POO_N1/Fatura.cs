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
        private int quanti;
        private double preco;    

        public Fatura(int c, int i, string d, int q,  double p)
        {
            Codigo = c;
            CodigoDoItem = i;
            Descrição = d;
            Preco = p;
            Quantidade = q;           
        }

        public Fatura()
        {
            
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
                return quanti;
            }
            set
            {
                quanti = value;
                if (quanti < 0)
                    quanti = 0;
                
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
                    throw new Exception("Não pode ser vazio!!");
                else
                    descr = value;
            }
        }
        public double TotalFatura()
        {
            double fatura = quanti * preco;
            return fatura;
        }

    }
}
