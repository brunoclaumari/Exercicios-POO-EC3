using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX13_INTERF
{
    class Produto : ICadastro
    {
        /*Produto:  codigo: int, string nome, double preco.*/

        int codigo;
        string nome;
        double preco;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("Insira somente valores positivos!!");
                else
                    codigo = value;
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                    throw new Exception("Não pode deixar em branco!!");
                else
                    nome = value;
            }
        }

        public double Preco
        {
            get => preco;
            set
            {
                if (value <= 0)
                    throw new Exception("Insira somente valores positivos!!");
                else
                    preco = value;
            }
        }

        public void Salvar()
        {
            string arquivo = "P|" + codigo + "|" + nome + "|" + preco+Environment.NewLine;
            File.AppendAllText("dados.txt", arquivo);
        }

        public String Pesquisar(string valor)
        {
            string achado = "";
            if (!File.Exists("dados.txt"))
            {
                throw new Exception("Arquivo não cadastrado");
                //return;
            }
            //List<Funcionario> leFunc = new List<Funcionario>();
            List<Produto> leProd = new List<Produto>();
            string[] aux = File.ReadAllLines("dados.txt");

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i].Trim().Length > 0 && aux[i].Split('|')[0].ToUpper().Contains('P'))
                {
                    Produto produt = new Produto();
                    //string[] aux2 = aux[i].Split('|');
                    produt.Codigo = Convert.ToInt32(aux[i].Split('|')[1].Trim());
                    produt.Nome = aux[i].Split('|')[2].Trim();
                    produt.Preco = Convert.ToDouble(aux[i].Split('|')[3].Trim());
                    leProd.Add(produt);                    
                }
                //else continue;

            }
            for (int n = 0; n < leProd.Count; n++)
            {
                if (leProd[n].Nome.ToUpper().Contains(valor.ToUpper()))
                {
                    achado = leProd[n].Codigo + "|" + leProd[n].Nome + "|"
                       + leProd[n].Preco;
                    break;
                }
                else
                    achado = null;

            }
            return achado;
        }
    }


}
