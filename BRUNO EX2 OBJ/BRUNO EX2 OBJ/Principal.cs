using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX2_OBJ
{
    public partial class Principal : Form
    {
        Jogo2[] jogos = new Jogo2[10];
        int qtde = 0;
        //Jogo2 j = null;
        //string[] vetor = new string[10];

        public Principal()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCategoria.Clear();
            txtData.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //int i = 0;

            bool temErro = false;
            if (qtde == 10)
            {
                MessageBox.Show("Limite de 10 atingido!");
                return;
            }

            try
            {
                //j = new Jogo2();
                //j.SetCodigo(Convert.ToInt32(txtCodigo.Text));
                //j.SetNome(txtNome.Text);
                //j.SetCategoria(txtCategoria.Text);
                //j.SetData(txtData.Text);
                //jogos[qtde] = j;

                jogos[qtde] = new Jogo2();

                jogos[qtde].SetCodigo(Convert.ToInt32(txtCodigo.Text));
                jogos[qtde].SetNome(txtNome.Text);
                jogos[qtde].SetCategoria(txtCategoria.Text);
                jogos[qtde].SetData(txtData.Text);

                qtde++;
            }
            catch (FormatException)
            {
                jogos = null;
                MessageBox.Show("Valores inválidos!");
                temErro = true;
            }
            catch (OverflowException erro)
            {
                MessageBox.Show("Número muuuito grande! " +
                    "Erro que deu: " + erro.Message);
                temErro = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                temErro = true;
            }
            if (temErro)
                return;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (jogos == null)
            {
                MessageBox.Show("Cadastre primeiro!!!");
            }
            else
            {
                lboxA.Items.Clear();
                for (int i = 0; i < qtde; i++)
                {

                    lboxA.Items.Add($"{i + 1} Código: " + jogos[i].GetCodigo() + Environment.NewLine +
                                               " Nome: " + jogos[i].GetNome() + Environment.NewLine +
                                               " Categoria: " + jogos[i].GetCategoria() + Environment.NewLine +
                                               " Data: " + jogos[i].GetData().ToShortDateString());
                }
            }


        }
    }
}
//j = new Jogo2();

//j.SetCodigo(Convert.ToInt32(txtCodigo.Text));
//j.SetNome(txtNome.Text);
//j.SetCategoria(txtCategoria.Text);
//j.SetData(txtData.Text);

//jvetor[i] = j;