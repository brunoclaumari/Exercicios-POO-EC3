using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX12_OBJ
{
    public class Funcionario
    {
        //public String Nome { get; set; }
        //public EnumSexo Sexo {get;set;}
        //public EnumECivil Ecivil { get; set; }
        //public DateTime DataNascimento { get; set; }

        //public Funcionario(string nome,EnumSexo sexo,EnumECivil estCivil,DateTime dataNascimento)
        //{
        //    this.Nome = nome;
        //    this.Sexo = sexo;
        //    this.Ecivil = estCivil;
        //    DataNascimento = dataNascimento; //Jeito mais curto!!!           
        //}
        string nome;
        EnumSexo sexo;
        EnumECivil estCivil;
        DateTime dataNascimento;

        public string Nome
        {
            get => nome;
            set { }

        }
        public EnumSexo Sexo
        {
            get => sexo;
            set { }

        }
        public EnumECivil Ecivil
        {
            get => estCivil;
            set { }

        }
        public DateTime DataNascimento
        {
            get => dataNascimento;
            set { }
        }
        public Funcionario(string nome, EnumSexo sexo, EnumECivil estCivil, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            Ecivil = estCivil;
            DataNascimento = dataNascimento;
        }

        public Funcionario()
        {

        }


    }
}
