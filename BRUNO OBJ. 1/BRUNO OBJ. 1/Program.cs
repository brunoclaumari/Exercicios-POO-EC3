using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_OBJ._1
{
    class Program
    {
        class Aluno
        {
            public int ra;
            public string nome;
            public double n1;
            public double n2;

            public double CalculaMediaFinal()
            {
                return n1*0.4 + n2*0.6;
            }
        }
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Digite o ra: ");
            aluno1.ra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            aluno1.nome = Console.ReadLine();
            Console.WriteLine("Digite a n1: ");
            aluno1.n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a n2: ");
            aluno1.n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média final: {0}", aluno1.CalculaMediaFinal());
            Console.ReadLine();
        }
    }
}
