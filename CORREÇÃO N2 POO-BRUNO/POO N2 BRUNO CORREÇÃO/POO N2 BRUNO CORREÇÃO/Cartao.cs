using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_N2_BRUNO_CORREÇÃO
{
    class Cartao
    {
        string numCartao;
        double limiteCredito;
        List<CompraCartao> listaComp;

        public InstaCartao()
        {
            listaComp = new List<CompraCartao>();
        }

        public string GetProduto()
        {            
            return numCartao;
        }
        public void SetProduto(string p)
        {
            if (p.Length == 0)
                throw new Exception("Erro!Está vazio!!");
            else
                numCartao = p;
        }

        public double GetLimite()
        {
            return limiteCredito;
        }
        public void SetLimite(double lm)
        {
            if (limiteCredito<0)
                throw new Exception("Não pode ser negativo");
            else
                limiteCredito = lm;
        }
        public double TotalComp()
        {
            double total = 0;
            foreach(CompraCartao comp in listaComp)
                total+=
        }
    }
}
