using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX12_OBJ
{
    public static class Metodos
    {
        public static bool ValidaNome(string nome)
        {
            if (nome.Trim().IndexOf(' ') == -1)
                return false;
            else
                return true;
        }

        public static bool ValidaData(string data, out int idade)
        {
            idade = 0;
            double aux = 0;
            double aux2 = 0;
            if (DateTime.TryParse(data, out DateTime DataConvertida))
            {
                //idade = (int)DateTime.Now.Subtract(DataConvertida).TotalDays / 365;//jeito mais facil
                aux = Convert.ToDouble((DateTime.Now.DayOfYear - DataConvertida.DayOfYear)) / 365;
                aux2 = Convert.ToDouble(DateTime.Now.Year - DataConvertida.Year) + aux;

                idade = (int)aux2;
                return true;            }
            else
                return false;
        }
    }
}
