using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX10_OBJ
{
    public partial class Form1 : Form
    {

        #region//Descrição do Exercício
        /*
    //        Crie uma classe chamada ContaCorrente
    //A classe deverá ter os seguintes atributos:

    //agencia int
    //numero da conta  string
    //nometitular    string
    //Saldo(apenas leitura)  double (inicia com zero)

    //Deverá haver um construtor parametrizado para 
    //que seja possível passar todos os parâmetros
    //já na criação do objeto.Deverá haver os métodos:

    //* void Saque(double valor) - subtrai do saldo.
    Deve gerar uma exceção caso o saldo não seja suficiente.

    //* void Deposito (double valor) - acrescenta o valor ao saldo.*/
        #endregion/

        List<ContaCorrente> listacc = new List<ContaCorrente>();
        int quant = 0;

        public Form1()
        {
            InitializeComponent();
            //txtSaldo.Text = "0.00";
        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente ContaCorr = new ContaCorrente(Convert.ToInt32(txtAgencia.Value),
                     txtConta.Text, txtTitular.Text);
                listacc.Add(ContaCorr);
                txtSaldo.Text = "0";
                quant++;               
                if(quant > 1)
                {
                    if (listacc[quant - 2].NumConta == txtConta.Text)
                    {
                        MessageBox.Show("Conta já existe!!");
                        listacc.Remove(ContaCorr);
                        quant--;
                        return;
                    }
                }                
               
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente contaPesq = null;
                for (int i = 0; i < listacc.Count; i++)
                {
                    if (listacc[i].NumConta == txtProcConta.Text)
                    {
                        contaPesq = listacc[i];
                        break;
                    }
                }
                if (contaPesq != null)
                {
                    contaPesq.Saque((double)txtSaque.Value);
                    txtSaldo.Text = contaPesq.Saldo.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Conta não encontrada!!");
                }
            }
            catch (Exception erro)
            {
                //cc = null;
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            ContaCorrente contaPesq = null;
            for (int n = 0; n < listacc.Count; n++)
            {
                if (listacc[n].NumConta == txtProcConta.Text)
                {
                    contaPesq = listacc[n];
                    break;
                }
            }
            if (contaPesq != null)
            {
                contaPesq.Deposito((double)txtDeposito.Value);
                txtSaldo.Text = contaPesq.Saldo.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Conta não encontrada!!");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < listacc.Count; i++)
            {
                listBox1.Items.Add($"Agencia: {listacc[i].Agencia} - " +
                                   $"Conta: {listacc[i].NumConta} - " +
                                   $"Titular: {listacc[i].Titular} - " +
                                   $"Saldo: {listacc[i].Saldo}");
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //ContaCorrente pesquisa = null;
            bool encontrado = false;

            for (int n = 0; n < listacc.Count; n++)
            {
                if (listacc[n].NumConta == txtProcConta.Text)
                {
                    txtAgencia.Value = listacc[n].Agencia;
                    txtConta.Text = listacc[n].NumConta;
                    txtTitular.Text = listacc[n].Titular;
                    txtSaldo.Text = listacc[n].Saldo.ToString();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Conta não encontrada");
                return;
            }




        }
    }
}

