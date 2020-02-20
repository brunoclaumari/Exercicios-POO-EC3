using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_BRUNO_JOAO
{
    public partial class Form1 : Form
    {
        /*
         * A fim de representar empregados em uma firma, 
         * crie uma classe chamada Empregado que inclui as informações a seguir como atributos:
            _ um nome (string)
            _ um salário mensal (double)

            Sua classe deve ter um construtor parametrizado que inicializa os três atributos.  
            Não crie um construtor padrão.
            Encapsule os atributos da classe.  
            Se o salário mensal não for positivo, configure-o como 0.0.
            Crie um método para aplicar um aumento no salário, 
            onde o usuário irá informar via parâmetro o valor em R$ do aumento. Ex: AumentaSalario(150.00) à será aplicado um aumento de 150,00 no salário do empregado.
            Sobrecarregue o método AumentaSalario(data), 
            onde deverá ser possível informar a data de admissão do funcionário via parâmetro (datetime). O aumento será de 1% para cada ano trabalhado.

            Adicione no seu formulário botões para:
            •Cadastrar um empregado
            •Exibir os dados do empregado
            •Aumentar o salário com base em R$
            •Aumentar o salário com base na data de admissão
             */

        Empregado emp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                emp = new Empregado(txtNome.Text, Convert.ToDouble(txtSalario.Text));
                //emp.Nome = txtNome.Text;
                //emp.Salario = Convert.ToDouble(txtSalario.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor incorreto, impossível converter");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAumentoData_Click(object sender, EventArgs e)
        {
            try
            {
                if (emp == null)
                {
                    MessageBox.Show("Formulario vazio!!");
                    return;
                }
                else
                {
                    DateTime aux = Convert.ToDateTime(txtDataAum.Text);
                    emp.AumentaSalario(aux);
                    txtSalario.Text = emp.Salario.ToString("0.00");
                    btnAumentoData.Enabled = false;
                }
                

            }
            catch (FormatException)
            {
                MessageBox.Show("Valor incorreto, impossível converter");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAumentoValor_Click(object sender, EventArgs e)
        {
            try
            {
                if (emp == null)
                {
                    MessageBox.Show("Formulario vazio!!");
                    return;
                }
                else
                {
                    emp.AumentaSalario(Convert.ToDouble(txtValorAum.Text));
                    txtSalario.Text = emp.Salario.ToString("0.00");
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor incorreto, impossível converter");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnExibe_Click(object sender, EventArgs e)
        {
            if (emp == null)
            {
                MessageBox.Show("Formulario vazio!!");
                return;
            }
            else
            {
                txtExibir.Clear();
                txtExibir.Text = $"Nome: {emp.Nome} Salário: {emp.Salario}";
            }

            
        }
    }
}
