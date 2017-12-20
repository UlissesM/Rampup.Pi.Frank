using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.cs
{
    public class CalculaSalario
    {
        public double CalculadoraSalario(Funcionario func)
        {
            if (func.Salario > 3000) return 3200.0;
            return 1350.0;
        }
    }
}
