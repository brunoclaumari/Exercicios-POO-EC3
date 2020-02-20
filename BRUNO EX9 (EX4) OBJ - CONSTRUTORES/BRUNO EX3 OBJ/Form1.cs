using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX3_OBJ
{
    public partial class Form1 : Form
    {
        Funcionario ff;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ff = new Funcionario(Convert.ToInt32(txtCodigo.Text),
                    txtNome.Text,
                    txtRG.Text,
                    Convert.ToDouble(txtSalario.Text));
                //ff.Codigo = (Convert.ToInt32(txtCodigo.Text));
                //ff.Nome = (txtNome.Text);
                //ff.Rg = (txtRG.Text);
                //ff.Salario = (Convert.ToDouble(txtSalario.Text));

            }
            catch (Exception erro)
            {
                ff = null;
                MessageBox.Show(erro.Message);
            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (ff == null)
                MessageBox.Show("Criar primeiro");
            {
                txtResumo.Text =
                    "Código: " + ff.Codigo + " - " +
                    "Nome: " + ff.Nome + " - " +
                    "RG: " + ff.Rg + " - " +
                    "Salário Bruto: " + ff.Salario.ToString("0.00") + " - " +
                    "INSS: " + ff.Inss.ToString("0.00") + " - " +
                    "Salário Líquido: " + ff.CalculaSalario().ToString("0.00");

            }
        }
    }
}
