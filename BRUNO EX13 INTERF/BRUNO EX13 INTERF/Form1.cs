using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX13_INTERF
{
    public partial class Form1 : Form
    {
        /*
         Crie uma Interface ICadatro que possua os métodos 
         Salvar e Pesquisar.  As assinaturas dos métodos são:
        Void Salvar();
        String Pesquisar(string valor);

        Coloque também 2 Propriedades: int Codigo e string Nome

        Crie 2 classes: Funcionario e Produto e 
        implemente esta interface em ambos.

        Atributos:
        Funcionario: codigo: int,  string nome
        Produto:  codigo: int, string nome, double preco.

        O método salvar de ambas as classes  
        deve salvar os dados em um arquivo texto (dados.txt), 
        acumulando os registros, um por linha, de forma que fique assim no arquivo:
        F|codigo|nome  		 para nomes
        P|codigo|nome|preco  	 para produtos

        Faça a interface gráfica para cadastrar produtos e funcionários.

        A pesquisa se dará pelo nome e caso encontre 
        os atributos do objeto devem ser preenchidos. 
        Preencha também os campos na tela após efetuar 
        a pesquisa ou limpe-os caso não encontre.

        */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesqFuncNome_Click(object sender, EventArgs e)
        {

            try
            {
                Funcionario f = new Funcionario();
                string achou = f.Pesquisar(txtPNomeFun.Text.ToUpper());
                
                if (achou == null)
                {
                    MessageBox.Show("Nome não cadastrado!!!");
                    return;
                }
                else
                {
                    txtCodigoF.Text = achou.Split('|')[0];
                    txtNomeF.Text = achou.Split('|')[1];
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void btnSalvaFunc_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Codigo = Convert.ToInt32(txtCodigoF.Text.Trim());
                f.Nome = txtNomeF.Text.Trim();

                f.Salvar();

                txtCodigoF.Clear();
                txtNomeF.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);                
            }
           
        }

        private void btnSalvaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.Codigo = Convert.ToInt32(txtCodigoP.Text.Trim());
                p.Nome = txtNomeP.Text.Trim();
                p.Preco = Convert.ToDouble(txtPrecoP.Text.Trim());

                p.Salvar();

                txtCodigoP.Clear();
                txtNomeP.Clear();
                txtPrecoP.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPesqProdNome_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                string achou = p.Pesquisar(txtPNomeProd.Text.ToUpper());

                if (achou == null)
                {
                    MessageBox.Show("Nome não cadastrado!!!");
                    return;
                }
                else
                {
                    txtCodigoP.Text = achou.Split('|')[0];
                    txtNomeP.Text = achou.Split('|')[1];
                    txtPrecoP.Text = achou.Split('|')[2];
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
