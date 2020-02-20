using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRUNO_EX12_OBJ
{
    public partial class Form1 : Form
    {
        /*
        EX_12
        ***** Métodos, atributos e classes estáticas e enumeradores *****
        Crie um enumerador para representar o sexo (Masculino e Feminino) 
        e outro para representar os estados civis (casado, solteiro, viúvo) 
        de um funcionário.
        Crie a classe funcionário com os seguintes atributos:

        string nome
        SexoEnum sexo
        ECivilEnum estado civil
        datetime data de nascimento

        Crie uma classe chamada métodos e crie os seguintes métodos estáticos:
            
        bool validanome (string nome) - 
        deverá validar se o nome possui nome e sobrenome.

        bool validaData (string data, out idade) - 
        deverá ver se a data informada é valida. Se for válida, retornar a idade no parâmetro de saída.

        Crie um construtor padrão e outro parametrizado 
        onde será possível informar todos os atributos.

        Crie um formulário e valide os dados utilizando estes métodos             

        */
        Funcionario func = new Funcionario();

        public Form1()
        {
            InitializeComponent();
            cbECivil.DataSource = Enum.GetValues(typeof(EnumECivil));
            cbSexo.DataSource = Enum.GetValues(typeof(EnumSexo));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Metodos.ValidaNome(txtNome.Text) == false)
            {
                MessageBox.Show("Tem que ter nome e sobre nome");
                return;
            }

            int idade;
            if (!Metodos.ValidaData(txtData.Text, out idade))
            {
                MessageBox.Show("Data inválida");
                return;
            }
            else
                lblIdade.Text = $"{idade} ano(s)";

            func.Nome = txtNome.Text;
            func.Ecivil = (EnumECivil)cbECivil.SelectedItem;
            func.Sexo = (EnumSexo)cbSexo.SelectedItem;
            func.DataNascimento = Convert.ToDateTime(txtData.Text);
                
        }
    }
}
