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

        ContaCorrente cc;

        public Form1()
        {
            InitializeComponent();

        }
        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                cc = new ContaCorrente(Convert.ToInt32(txtAgencia.Value),
                     txtConta.Text, txtTitular.Text);
                btnCriar.Enabled = false;
                btnDeposito.Enabled = btnSaque.Enabled =
                    txtDeposito.Enabled = txtSaldo.Enabled = true;

                txtSaldo.Text = "0";
            }
            catch (Exception erro)
            {
                cc = null;
                MessageBox.Show(erro.Message);
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                cc.Saque(Convert.ToDouble(txtSaque.Value));
                txtSaldo.Text = cc.Saldo.ToString("0.00");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                cc.Deposito(Convert.ToDouble(txtDeposito.Value));
                txtSaldo.Text = cc.Saldo.ToString("0.00");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        

    }
}
