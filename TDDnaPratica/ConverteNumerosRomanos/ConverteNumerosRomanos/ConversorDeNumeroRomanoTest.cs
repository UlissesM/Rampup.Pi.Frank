using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace ConverteNumerosRomanos
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
         }
    }
}
