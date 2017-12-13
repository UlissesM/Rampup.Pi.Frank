using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTDD
{
    public class Produto : Object
    {
        public string descricao { get; set; }
        public double valor { get; set; }

        public Produto(string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public override bool Equals(object obj)
        {
            obj = (Produto)obj;
            return base.Equals(obj);
        }

    }
}
