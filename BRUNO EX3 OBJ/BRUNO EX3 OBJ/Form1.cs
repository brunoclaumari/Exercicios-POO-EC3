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
                ff = new Funcionario();
                ff.SetCodigo(Convert.ToInt32(txtCodigo.Text));
                ff.SetNome(txtNome.Text);
                ff.SetRg(txtRG.Text);
                ff.SetSalario(Convert.ToDouble(txtSalario.Text));

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
                    "Código: " + ff.GetCodigo() +" - "+
                    "Nome: "+ff.GetNome() +" - "+
                    "RG: " + ff.GetRg() + " - " +
                    "Salário Bruto: " + ff.GetSalario() + " - " +
                    "INSS: " + ff.GetINSS() + " - " +
                    "Salário Líquido: " + ff.CalculaSalario();
                   
            }
        }
    }
}
