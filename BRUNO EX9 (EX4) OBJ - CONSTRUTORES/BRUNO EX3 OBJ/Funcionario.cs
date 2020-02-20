using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX3_OBJ
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public Funcionario(int codbuild,string nomebuild,string rgbuild,double salariobuild)//Esse é o Construtor!!
        {
            Codigo = codbuild;
            Nome = nomebuild;
            Rg = rgbuild;
            Salario = salariobuild;
        }


        public int Codigo //Essa é uma das propriedades(get/set)
        {
            get
            {
                return codigo;// OBS: MELHOR JEITO!!!
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Código não pode ser negativo!!!");
                else
                    codigo = value;
            }
        }
       
        public string Nome
        {
            //get
            //{
            //    return nome;//1º jeito de fazer - OBS: MELHOR JEITO!!!

            //}
            get => nome; //2º jeito de fazer
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Digite o nome!!");
                else
                    nome = value;
            }
        }
               
        public string Rg
        {
            get
            {
                return rg;//1º jeito de fazer - OBS: MELHOR JEITO!!!
            }
            //get => rg;    //2º jeito de fazer
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Digite o RG");
                else
                    rg = value;
            }
        }
      
        public double Salario
        {
            //get => salario;//1º jeito de fazer
            get
            {
                return salario;//2º jeito de fazer-OBS: MELHOR JEITO!!!
            }
            set
            {
                if (value < 0)
                    throw new Exception("Salario nao pode ser negativo!");
                else
                    salario = value;
            }
        }

               
        public double Inss
        {
            //get => salario * 0.11;//1º jeito de fazer    
            get
            {
                return salario * 0.11; //2º jeito de fazer
            }
        }
        public double CalculaSalario()
        {
            return salario - Inss;
        }


        
    }
}
