using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX2_OBJ
{
    //    1.	Crie uma classe chamada Jogo com seguintes atributos:
    //•	Código -  inteiro
    //•	Nome  - string
    //•	Categoria – string
    //•	Data de lançamento -  DateTime

    //Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.


    //2.	Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos.Após efetuar os cadastros, exiba os dados em vídeo.

    class Jogo2
    {
        //const int MAX = 10;
        private int codigo;
        private string nome;
        private string categoria;
        private DateTime data;

        //informa o codigo
        public void SetCodigo(int valor)
        {

            if (valor <= 0)

                throw new Exception("Codigo deve ser >=1");
            else
                codigo = valor;

        }
        //obtem o codigo
        public int GetCodigo()
        {
            return codigo;
        }
        //informa o nome
        public void SetNome(string nomejogo)
        {
            if (string.IsNullOrEmpty(nomejogo)==true)
                throw new Exception("Nome obrigatório!!");
            else
                nome = nomejogo;
        }
        //obtem o nome
        public string GetNome()
        {
            return nome;
        }
        //informa a categoria
        public void SetCategoria(string genero)
        {
            if (string.IsNullOrEmpty(genero)==true)
                throw new Exception("Categoria é obrigatória!!");
            else
                categoria = genero;
        }
        //obtem a categoria
        public string GetCategoria()
        {
            return categoria;
        }
        //informa da data
        public void SetData(string datacompra)
        {
            try
            {
                data=Convert.ToDateTime(datacompra);
            }
            catch
            {
                throw new FormatException("Data inválida!!!");
                
            }
        }
        //obtem a data
        public DateTime GetData()
        {
            return data;
        }

    }
}
