using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX20
{
    public partial class Form1 : Form
    {
        List<Veiculo> lista = new List<Veiculo>();
        Veiculo pesquisado = null;

        public Form1()
        {
            InitializeComponent();
        }
        public void Mensagem(Veiculo vei)
        {
            MessageBox.Show(vei.Descricao.ToString() + " cadastrado!!");
        }


        private void btnCarro_Click(object sender, EventArgs e)
        {

            try
            {
                Carro car = new Carro()
                {
                    Descricao = txtNome.Text,
                    VelocidadeLimpador = Convert.ToInt16(txtVelocidadeLimpador.Text),
                    CapacidadeMaximaEmKg = Convert.ToDouble(txtCapacidade.Text),
                    QtdePortas = Convert.ToInt16(txtQtdePortas.Text),
                    UtilizaReboque = ckUtilizaReboque.Checked

                };
                lista.Add(car);
                Mensagem(car);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCriarMoto_Click(object sender, EventArgs e)
        {
            try
            {
                Moto moto = new Moto()
                {
                    Descricao = txtNome.Text,
                    Cilindradas = Convert.ToInt16(txtCilindradas.Text),
                    CapacidadeMaximaEmKg = Convert.ToDouble(txtCapacidade.Text)
                };
                lista.Add(moto);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnCriarCaminhao_Click(object sender, EventArgs e)
        {

            try
            {
                Caminhao bruto = new Caminhao()
                {
                    Descricao = txtNome.Text,
                    QuantEixos = Convert.ToInt32(txtQtdeEixos.Text),
                    CapacidadeMaximaEmKg = Convert.ToDouble(txtCapacidade.Text),
                    VelocidadeLimpador = Convert.ToInt16(txtVelocidadeLimpador.Text)
                };
                lista.Add(bruto);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisado = null;
            foreach (Veiculo v in lista)
            {
                if (v.Descricao.ToUpper().Trim().Equals(txtPesqVeiculo.Text.ToUpper()))
                {
                    pesquisado = v;
                    txtOutput.Clear();
                    txtOutput.Text = pesquisado.ToString();
                    break;
                }
            }
            if (pesquisado == null)
                MessageBox.Show("Item não encontrado!!");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisado == null)
                    MessageBox.Show("Pesquisar primeiro!!");
                else
                    pesquisado.Carregar(Convert.ToDouble(txtCarregar.Text));

            }
            catch (CapacidadeMaximaExcedidaException erro)
            {
                MessageBox.Show("Cuidado, provavelmente não é caminhão e deu erro" + erro.Message);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            if (pesquisado == null)
                MessageBox.Show("Pesquisar primeiro!!!");
            else
            {
                if (pesquisado is Moto)
                    (pesquisado as Moto).Empinar();
                else
                    MessageBox.Show("Não é moto");
            }

        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            if (pesquisado == null)
                MessageBox.Show("Pesquisar primeiro");
            else
                if (pesquisado is Caminhao)
                (pesquisado as Caminhao).Descarregar();
            else
                MessageBox.Show("Não é caminhão!");

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisado == null)
                    MessageBox.Show("Pesquisar primeiro!!");
                else
                    pesquisado.Acelerar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPagarPedagio_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisado == null)
                    MessageBox.Show("Pesquisar primeiro!!");
                else
                    txtOutput.Text+= pesquisado.PagarPedagio();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAbrirPortas_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisado == null)
                    MessageBox.Show("Pesquisar primeiro!!");
                else
                {
                    foreach (Veiculo veiculo in lista)
                    {
                        if (veiculo is Carro)
                            (veiculo as Carro).AbrirPorta();
                        else if (veiculo is Caminhao)
                            (veiculo as Carro).AbrirPorta();
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcionaLimpador_Click(object sender, EventArgs e)
        {
            try
            {                
                    foreach (Veiculo veiculo in lista)
                    {
                        if (veiculo is Carro)
                            (veiculo as Carro).AcionarLimpador();
                        else if (veiculo is Caminhao)
                            (veiculo as Carro).AcionarLimpador();
                    }               

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            foreach(var vei in lista)
            {
                txtOutput.Text += vei.ToString() + Environment.NewLine;
            }
        }
    }
}
