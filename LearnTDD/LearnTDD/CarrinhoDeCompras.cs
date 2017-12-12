using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTDD
{
    public class CarrinhoDeCompras
    {

        public List<Produto> produtos = new List<Produto>();
        public void Adiciona(Produto p)
        {
            produtos.Add(p);
           
        }
    }
}
