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

        //Fatura faturaAtual;
        private void btnCadastraFatura_Click(object sender, EventArgs e)
        {
            try
            {
                Fatura fatura = new Fatura(Convert.ToInt16(txtCod.Text),
                    Convert.ToInt16(txtIten.Text), txtDescr.Text, Convert.ToInt16(txtQtd.Text),
                     Convert.ToDouble(txtPre.Text));

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
                foreach(Fatura teste in lista)
                {
                    if (teste.Codigo == Convert.ToInt32(txtCod.Text))
                    {
                        MessageBox.Show("Código já existe!!!");
                        break;
                    }
                    else
                        lista.Add(fatura);
                }

                //faturaAtual = fatura;
                lista.Add(fatura);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números nos campos correspondentes");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDescr.Clear();
            txtFatu.Clear();
            txtIten.Clear();
            txtPre.Clear();
            txtQtd.Clear();
            txtListando.Clear();
            //lista.Add(faturaAtual);
            foreach (Fatura fat in lista)
            {
                /*
                Codigo = c;
                CodigoDoItem = i;
                Descrição = d;
                Preco = p;
                Quantidade = q; */
                txtListando.Text += fat.Codigo + " - " +
                                    fat.CodigoDoItem + " - " +
                                    fat.Descrição + " - " +
                                    fat.Preco + " - " +
                                    fat.Quantidade + " - " +
                                    fat.TotalFatura() + Environment.NewLine;
            }
        }

        private void btnExcluirDaLista_Click(object sender, EventArgs e)
        {
            foreach (Fatura proc in lista)
            {
                if (proc.Codigo == Convert.ToInt32(txtCodExcluir.Text))
                {
                    lista.Remove(proc);
                    break;
                }
                else
                    MessageBox.Show("Código solicitado não existe!!!");
            }
        }
    }
}
