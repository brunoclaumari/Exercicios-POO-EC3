﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRUNO_EX14_OBJ
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return Codigo + "-" + Descricao +
                " - Categ.: " + Categoria.ToString();
        }
    }
}
