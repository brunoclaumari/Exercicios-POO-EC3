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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.NomeAluno = (txtNome.Text);
                aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
                aluno.Nota2 = Convert.ToDouble(txtNota2.Text);

                lboxMedia.Items.Add($"Nome: {aluno.NomeAluno} - Média: {aluno.Media}");
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
    }
}
