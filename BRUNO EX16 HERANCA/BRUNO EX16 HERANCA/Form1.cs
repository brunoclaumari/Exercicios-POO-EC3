using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX16_HERANCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Funcionario> lista = new List<Funcionario>();

        private void PreecherPropriedades(Funcionario f)
        {
            /*
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public double Salario { get; set; }
            public double Descontos
             */
            f.Codigo = Convert.ToInt16(txtCodigo.Text);
            f.Nome = txtNome.Text;
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Descontos = Convert.ToDouble(txtDesconto.Text);
        }

        private void btnInstanciaPeao_Click(object sender, EventArgs e)
        {
            FuncionarioPiao piao = new FuncionarioPiao();
            PreecherPropriedades(piao);
            piao.ValorHExtra = Convert.ToDouble(txtValorHExtra.Text);
            lista.Add(piao);
        }

        private void btnInstanciaGerente_Click(object sender, EventArgs e)
        {
            FuncionarioGerente ger = new FuncionarioGerente();
            PreecherPropriedades(ger);
            ger.Bonus = Convert.ToDouble(txtBonus.Text);
            ger.QtdeFuncSubordinados =Convert.ToInt32(txtQtdeFunc.Value);
            lista.Add(ger);
        }

        private void btnInstanciaVendedor_Click(object sender, EventArgs e)
        {
            FuncionarioVendedor vend = new FuncionarioVendedor();
            PreecherPropriedades(vend);
            vend.MetasDeVendasMes =Convert.ToDouble(txtMeta.Text);
            vend.VendasDoMesEmReais = Convert.ToDouble(txtVendasMes.Text);
            vend.PorcentagemSobreVendas = Convert.ToDouble(txtPorcentXVendas.Text);
            lista.Add(vend);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtListarItens.Clear();
            foreach(Funcionario f in lista)
            {
                txtListarItens.Text += f.ToString();
            }
        }
    }
}
