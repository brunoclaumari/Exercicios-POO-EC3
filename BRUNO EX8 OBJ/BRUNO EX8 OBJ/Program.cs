using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX8_OBJ
{
    class Program
    {

        //Faça método sobrecarregado para salvar em um arquivo texto o conteúdo passado por parâmetro.
        //Quando não for passado por parâmetro o caminho, salve na pasta da aplicação.

        //Crie as seguintes versões do método:
        //Salva (string texto)
        //Salva (string texto, string caminho)
        //Salva(string[] vetor)
        //Salva(string[] vetor, string caminho)
        static void Salva(string texto, string caminho)
        {
            File.WriteAllText(caminho, texto);
        }
        static void Salva(string texto)
        {
            Salva(texto, "dados.txt");
        }
        static void Salva(string[] vetor)
        {
            Salva(vetor, "dados2.txt");
        }
        static void Salva(string[] vetor, string caminho)
        {
            string r = "";

            r = string.Join(Environment.NewLine, vetor);
            Salva(r, caminho);
        }


        static void Main(string[] args)
        {
            Salva("Método que salva sem caminho!!");
            Salva("Método que salva com caminho", "e:\\teste1.txt");
            Salva(new string[] { "A", "B", "C" });// salva um vetor sem caminho
            Salva(new string[] { "A", "B", "C" }, "e:\\teste2.txt");
        }
    }
}
