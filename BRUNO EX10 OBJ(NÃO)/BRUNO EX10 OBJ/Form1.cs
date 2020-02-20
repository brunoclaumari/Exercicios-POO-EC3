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
            txtSaldo.Text = "0";
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                cc = new ContaCorrente(Convert.ToInt32(txtAgencia.Text),
                     txtConta.Text, txtTitular.Text);
                cc = new ContaCorrente(Convert.ToDouble(txtSaldo.Text));

                txtSaldo.Text = cc.Saque(txtSaque.Text).ToString();
            }
            catch (Exception erro)
            {
                //cc = null;
                MessageBox.Show(erro.Message);
                return;
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                cc = new ContaCorrente(Convert.ToInt32(txtAgencia.Text),
                    txtConta.Text, txtTitular.Text);
                cc = new ContaCorrente(Convert.ToDouble(txtSaldo.Text));

                txtSaldo.Text = cc.Deposito(txtDeposito.Text).ToString();

            }
            catch (Exception erro)
            {
                //cc = null;
                MessageBox.Show(erro.Message);
                return;
            }

        }
    }
}
