using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX14_OBJ
{
    class Categoria : object
    {
        /*         
         Faça um cadastro de produtos com os seguintes atributos: código, descrição, categoria. A categoria deve estar em um combobox.
         Guarde os produtos em uma lista.
         Coloque um botão na tela para listar 
         todos os produtos em um listbox ou textbox, 
         listando o código, a descrição do produto 
         e a descrição da categoria.
         */
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public static List<Categoria> Carregar()
        {
            List<Categoria> lista = new List<Categoria>();
            if (File.Exists("Categoria.txt"))
            {
                String[] linhas = File.ReadAllLines("Categoria.txt");
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(',');
                    Categoria cat = new Categoria();
                    cat.Codigo = Convert.ToInt32(dados[0]);
                    cat.Descricao = dados[1];
                    lista.Add(cat);
                }
            }
            return lista;
        }
        public override string ToString()
        {
            return Codigo + " - " + Descricao;
        }
    }
}
