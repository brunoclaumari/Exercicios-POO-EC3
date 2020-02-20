using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX14_OBJ
{
    public partial class Form1 : Form
    {
        List<Produto> listPr = new List<Produto>();

        public Form1()
        {
            InitializeComponent();

            cbCategorias.DataSource = Categoria.Carregar();
            cbCategorias.ValueMember = "Codigo";
            cbCategorias.DisplayMember = "Descricao";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto pr = new Produto();
                pr.Codigo = Convert.ToInt32(txtCodigo.Text);
                pr.Descricao = txtDescricao.Text;
                pr.Categoria = (Categoria)cbCategorias.SelectedItem;
                listPr.Add(pr);
                //txtExibir.AccessibleDefaultActionDescription = null;
                //txtExibir.AccessibleDefaultActionDescription = listPr.ToString();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());                
            }
            
        }
    }
}
