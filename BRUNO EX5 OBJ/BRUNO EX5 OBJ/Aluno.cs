using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX5_OBJ
{
    class Aluno
    {
        private string nome_aluno;
        private double nota1;
        private double nota2;

        public string NomeAluno
        {
            get
            {
                return nome_aluno;
            }
            set
            {
                //if (string.IsNullOrEmpty(value) == true)
                //    throw new Exception("Escreva o nome do aluno!!");
                //else if (value.Trim().IndexOf(' ') == -1)
                //    throw new Exception("Digite nome e sobrenome!!!");
                if (string.IsNullOrEmpty(value) == true || value.Trim().IndexOf(' ') == -1)
                    throw new Exception("Digite nome e sobrenome!!!");

                nome_aluno = value;
            }
        }

        public double Nota1
        {
            get
            {
                return nota1;
            }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota inválida!!" +
                        "As notas só podem de 0 a 10");
                else
                    nota1 = value;
            }
        }
        public double Nota2
        {
            get
            {
                return nota2;
            }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota inválida!!" +
                        "As notas só podem de 0 a 10");
                else
                    nota2 = value;
            }
        }
        public double Media
        {
            get
            {
                return (nota1 + nota2) / 2;
            }
        }

    }
}
