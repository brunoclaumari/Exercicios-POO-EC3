using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX17_ABSTRACT
{
    public partial class Form1 : Form
    {
        List<ContaBancaria> lista = new List<ContaBancaria>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriaCCorr_Click(object sender, EventArgs e)
        {
            lista.Add
                (new ContaCorrente()
                {
                    Nome = txtTitular.Text,
                    NumConta = txtCC.Text,
                    LimiteCredito = Convert.ToDouble(txtLimite.Value),
                    Saldo = 0,
                    UtilizaCheque = ckCheque.Checked
                }
                );
        }

        private void btnCriaCPoup_Click(object sender, EventArgs e)
        {
            var Cp = new ContaPoupanca()
            {
                Nome = txtTitular.Text,
                NumConta


            };

        }
    }
}
