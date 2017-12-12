using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTDD
{
    public class MaiorMenor
    {
        public Produto Menor { get; private set; }
        public Produto Maior { get; private set; }
        public void Encontra(CarrinhoDeCompras carrinho)
        {
            foreach (var produto in carrinho.produtos)
            {
                if (Menor == null || produto.valor < Menor.valor)
                {
                    Menor = produto;
                }
                if (Maior == null || produto.valor > Maior.valor)
                {
                    Maior = produto;
                }
            }
        }
    }
}
