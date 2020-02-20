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
        /*
         Altere o exercício 5 para que os dados sejam salvos em uma lista.
         Crie um botão para pesquisar um aluno pelo nome.
         Crie um botão para listar todos os alunos, exibindo todas as propriedades.
         Crie um botão para remover um aluno da lista.  */

        List<Aluno> listaAluno = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno(txtNome.Text, Convert.ToDouble(txtNota1.Text), Convert.ToDouble(txtNota2.Text));

                MessageBox.Show($"Nome: {aluno.NomeAluno} - Média: {aluno.Media}");

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno criaAluno = new Aluno(txtNome.Text, Convert.ToDouble(txtNota1.Text), Convert.ToDouble(txtNota2.Text));
                listaAluno.Add(criaAluno);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listaAluno.Count == 0)
            {
                MessageBox.Show("A lista está vazia!!!!");
                return;
            }
            else if (lboxMedia.SelectedItem != null)
            {
                int pos = lboxMedia.SelectedIndex;
                DialogResult msg = MessageBox.Show($"Removido: {listaAluno[pos].NomeAluno}");
                listaAluno.RemoveAt(pos);
                lboxMedia.Items.RemoveAt(pos);
                //if (msg == DialogResult.OK)
                //{
                //    btnListar.PerformClick();

                //}

                /*
                  lboxMedia.Items.Add($"Nome: {listaAluno[i].NomeAluno} - " +
                    $"N1: {listaAluno[i].Nota1} - " +
                    $"N2: {listaAluno[i].Nota2} - " +
                    $"Media: {listaAluno[i].Media}");
                 */

                //string valor = lboxMedia.SelectedItem.ToString();
                //Aluno aux = new Aluno(valor.Split('-')[0].ToString().Trim(), 
                //    Convert.ToDouble(valor.Split('-')[1].Replace("N1:","").Trim()),
                //    Convert.ToDouble(valor.Split('-')[2].Replace("N2:", "").Trim()));

                //for (int n = 0; n < listaAluno.Count; n++)
                //{
                //    if (aux.ToString().ToUpper().Contains(listaAluno[n].ToString().ToUpper()))
                //    {
                //        MessageBox.Show($"Removido: {listaAluno[n].NomeAluno}");
                //        listaAluno.RemoveAt(n);
                //        break;
                //    }
                //}
            }
            else if (lboxMedia.SelectedItem == null && txtValorNome.Text.Length != 0)
            {
                for (int i = 0; i < listaAluno.Count; i++)
                {
                    if (txtValorNome.Text.ToUpper() == listaAluno[i].NomeAluno.ToUpper() ||
                        listaAluno[i].NomeAluno.ToUpper().Contains(txtValorNome.Text.ToUpper()))
                    {
                        MessageBox.Show($"Removido: {listaAluno[i].NomeAluno}");
                        listaAluno.RemoveAt(i);
                        lboxMedia.Items.RemoveAt(i);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Não existe na lista!!");

        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            lboxMedia.Items.Clear();

            if (listaAluno.Count == 0)
            {
                MessageBox.Show("A lista está vazia!!!!");
                return;
            }
            else
            {
                for (int i = 0; i < listaAluno.Count; i++)
                {
                    lboxMedia.Items.Add($"Nome: {listaAluno[i].NomeAluno} - " +
                        $"N1: {listaAluno[i].Nota1} - " +
                        $"N2: {listaAluno[i].Nota2} - " +
                        $"Media: {listaAluno[i].Media}");

                }
            }
            //lboxMedia.Items.Add($"Nome: {aluno.NomeAluno} - Média: {aluno.Media}");
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaAluno.Count == 0)
                {
                    MessageBox.Show("A lista está vazia!!!!");
                    return;
                }
                else
                {
                    Aluno pesqAluno = null;
                    foreach (Aluno a in listaAluno)
                    {
                        if (a.NomeAluno.ToUpper() == txtValorNome.Text.ToUpper() ||
                            a.NomeAluno.ToUpper().Contains(txtValorNome.Text.ToUpper()))
                        {
                            pesqAluno = a;
                        }
                    }
                    if (pesqAluno != null)
                    {
                        txtNome.Text = pesqAluno.NomeAluno;
                        txtNota1.Text = pesqAluno.Nota1.ToString();
                        txtNota2.Text = pesqAluno.Nota2.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado!!!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
