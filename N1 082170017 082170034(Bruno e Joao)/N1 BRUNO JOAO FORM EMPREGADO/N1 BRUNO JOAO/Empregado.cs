using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_BRUNO_JOAO
{
    class Empregado
    {
        string nome;
        double salario;
        int tempo=0;
        public Empregado(string nomex,double salariox)
        {
            Nome = nomex;
            Salario = salariox;
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Não pode deixar em branco!!");
                else
                    nome = value;
            }
        }
        public double Salario
        {
            get => salario;
            set
            {
                if (value < 0)
                {
                    value = 0;
                    salario = value;
                }
                else
                    salario = value;
            }
        }

        public void AumentaSalario(double valor)
        {
            salario += valor;
        }

        public void AumentaSalario(DateTime dataAdm)
        {
            DateTime hoje = DateTime.Now;
            tempo = (Convert.ToInt32(hoje.Subtract(dataAdm).TotalDays) / 365);
            double aumento = tempo * 0.01;
            salario = salario + (salario * aumento);
        }
    }
}
