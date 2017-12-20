using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Funcionario.cs
{
    [TestFixture]
    public class FuncionarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculaSalario calculadora = new CalculaSalario();
            Funcionario desenvolvedor = new Funcionario("Dev",1500.0,Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalculadoraSalario(desenvolvedor);
            Assert.AreEqual(1500*0.9,salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            var calculadora = new CalculaSalario();
            var desenvolvedor = new Funcionario("Dev", 4000.0, Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalculadoraSalario(desenvolvedor);
            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioDBAsComSalariosAbaixoDoLimite()
        {
            CalculaSalario calculadora = new CalculaSalario();
            Funcionario dba = new Funcionario("db", 500.0, Cargo.DBA);
            double salario = calculadora.CalculadoraSalario(dba);
            Assert.AreEqual(500.0 * 0.85, salario);
        }     
        
    }
}
