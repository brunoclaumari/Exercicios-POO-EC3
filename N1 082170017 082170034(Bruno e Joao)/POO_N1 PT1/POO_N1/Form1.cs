using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_N1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Fatura> lista = new List<Fatura>();

        Fatura faturaAtual;
        private void btn_Click(object sender, EventArgs e)
        {                         
            try
            {
                Fatura fatura = new Fatura(Convert.ToInt16(txtCod.Text), Convert.ToInt16(txtIten.Text), Convert.ToInt16(txtQtd.Text), txtDescr.Text, Convert.ToDouble(txtPre.Text));

                /* 
                para construtor padrão
                 
                fatura.Codigo = Convert.ToInt16(txtCod.Text);
                fatura.CodigoDoItem = Convert.ToInt16(txtIten.Text);
                fatura.Descrição = txtDescr.Text;
                fatura.Preco = Convert.ToDouble(txtPre.Text);
                fatura.Quantidade = Convert.ToInt16(txtQtd.Text);
                */
                label6.Visible = true; 
                txtFatu.Visible = true;
                txtFatu.Text = fatura.TotalFatura().ToString();
                
                faturaAtual = fatura;
            }
            catch(FormatException )
            {
                MessageBox.Show("Digite apenas números nos campos correspondentes");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void butNCad_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDescr.Clear();
            txtFatu.Clear();
            txtIten.Clear();
            txtPre.Clear();
            txtQtd.Clear();
            lista.Add(faturaAtual);
        }
    }
}
