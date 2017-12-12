using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace LearnTDD
{
    [TestFixture]
    public class TestaMaiorMenor
    {
        [Test]
        public void OrdemDescresente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            MaiorMenor algoritmo = new MaiorMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos",
                algoritmo.Menor.descricao);

            Assert.AreEqual("Geladeira",
                algoritmo.Maior.descricao);
        }
    }
}
