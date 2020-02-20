using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX5_OBJ
{
    public partial class Form1 : Form
    {
        //Aluno aluno;
        Aluno[] aluno = new Aluno[10];
        int quant = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool temErro = false;
            //aluno = null;
            try
            {
                aluno[quant] = new Aluno();

                aluno[quant].NomeAluno = (txtNome.Text);
                aluno[quant].Nota1 = Convert.ToDouble(txtNota1.Text);
                aluno[quant].Nota2 = Convert.ToDouble(txtNota2.Text);

                quant++;
                if (quant == 10)
                    btnCadastrar.Enabled = false;
                Limpar();

            }
            catch (FormatException)
            {
                MessageBox.Show("Valores impossiveis de converter");
                temErro = true;

            }
            catch (Exception Erro)
            {
                //aluno = null;
                MessageBox.Show(Erro.Message);
                temErro = true;
                return;
            }
            if (temErro)
                return;
            if (quant >= 10)
            {
                MessageBox.Show("Sem espaço para mais cadastros!!!");
                return;
            }                
        }

        private void btnExibirMedia_Click(object sender, EventArgs e)
        {
            if (aluno == null && txtNome.Text.Length == 0)
            {
                MessageBox.Show("Crie primeiro!!");
                txtNome.Focus();
            }

            else
            {
                for (int i = 0; i < quant; i++)
                {
                    if (!lboxMedia.Items.Contains($"{i + 1}º" +
                        $" Nome: {aluno[i].NomeAluno} - " +
                        $"Média: {aluno[i].Media}"))
                        lboxMedia.Items.Add($"{i + 1}º Nome: {aluno[i].NomeAluno} - Média: {aluno[i].Media}");
                }
            }
        }
    }
}
