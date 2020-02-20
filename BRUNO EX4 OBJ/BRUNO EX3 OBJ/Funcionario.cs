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
        //Inss(somente leitura: não tem o método SET)

        //public void SetCodigo(int valorcod)
        //{
        //    if (valorcod < 0)
        //        throw new Exception("Código não pode ser negativo!!!");
        //    else
        //        codigo = valorcod;
        //}
        //public int GetCodigo()
        //{
        //    return codigo;
        //}
        public int Codigo
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

        //public void SetNome(string func)
        //{
        //    if (string.IsNullOrEmpty(func) == true)
        //        throw new Exception("Digite o nome!!");
        //    else
        //        nome = func;
        //}
        //public string GetNome()
        //{
        //    return nome;
        //}
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

        //public void SetRg(string ident)
        //{
        //    if (string.IsNullOrEmpty(ident) == true)
        //        throw new Exception("Digite o RG");
        //    else
        //        rg = ident;
        //}
        //public string GetRg()
        //{
        //    return rg;
        //}
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

        //public void SetSalario(double dindin)
        //{
        //    if (dindin < 0)
        //        throw new Exception("Salario nao pode ser negativo!");
        //    else
        //        salario = dindin;
        //}
        //public double GetSalario()
        //{
        //    return salario;
        //}
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

        //public double GetINSS()
        //{
        //    return salario * 0.11;
        //}        
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
