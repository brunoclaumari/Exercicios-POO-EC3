using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX7_OBJ
{
    class Program
    {
        private static double Soma(int v1, int v2)
        {
            return v1 + v2;
        }
        private static double Soma(string v1, string v2)
        {
            return Convert.ToDouble(v1) + Convert.ToDouble(v2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Soma(25, 23));
            Console.WriteLine(Soma("25", "23"));
            Console.ReadLine();
        }
    }
}
