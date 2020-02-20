using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX13_INTERF
{
    class Funcionario : ICadastro
    {
        /*Funcionario: codigo: int,  string nome*/
        int codigo;
        string nome;

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

        public void Salvar()
        {
            string arquivo = "F|" + codigo + "|" + nome + Environment.NewLine;
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
            else
            {

                List<Funcionario> leFunc = new List<Funcionario>();
                //List<Produto> leProd = new List<Produto>();
                string[] aux = File.ReadAllLines("dados.txt", Encoding.UTF8);

                for (int i = 0; i < aux.Length; i++)
                {
                    
                    if (aux[i].Trim().Length > 0 && aux[i].Split('|')[0].ToUpper().Contains('F'))
                    {
                        Funcionario colab = new Funcionario();
                        //string[] aux2 = aux[i].Split('|');
                        colab.Codigo = Convert.ToInt32(aux[i].Split('|')[1].Trim());
                        colab.Nome = aux[i].Split('|')[2].Trim();
                        leFunc.Add(colab);
                        
                    }
                    //else continue;

                }
                for (int n = 0; n < leFunc.Count; n++)
                {
                    if (leFunc[n].Nome.ToUpper().Contains(valor.ToUpper()))
                    {
                        achado = leFunc[n].Codigo + "|" + leFunc[n].Nome;
                        break;
                    }                        
                    else
                        achado = null;
                }
            }
            return achado;
        }

    }
}
//if (aux[i].Contains("F"))
//{
//    Funcionario colab = new Funcionario();
//    string aux2 = aux[i];
//    colab.Codigo = Convert.ToInt32(aux2.Split('|')[1]);
//    colab.Nome = aux2.Split('|')[2];
//    leFunc.Add(colab);
//}
//else continue;
