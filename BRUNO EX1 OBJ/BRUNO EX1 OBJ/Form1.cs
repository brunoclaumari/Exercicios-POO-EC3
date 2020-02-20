using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX1_OBJ
{
    public partial class Form1 : Form
    {
        Jogo game;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                game = new Jogo();
                game.codigo = Convert.ToInt32(txtCodigo.Text);
                game.nome = txtNome.Text;
                game.categoria = txtCategoria.Text;
                game.data = Convert.ToDateTime(txtData.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Valores inválidos");
            }
            catch(OverflowException erro)
            {
                MessageBox.Show("Número muito grande!!!!" + erro.Message);
            }
            

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Crie o jogo primeiro!!");
            }
            else
            {
                MessageBox.Show("Código: " + game.codigo + Environment.NewLine+
                                "Nome: " + game.nome + Environment.NewLine+
                                "Categoria: " + game.categoria + Environment.NewLine+
                                "Data: " + game.data.ToShortDateString());
            }
        }
    }
}
