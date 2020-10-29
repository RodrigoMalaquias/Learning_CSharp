using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_2
{
    class Funcionario
    {
        public string nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100.0));
        }

        public override string ToString()
        {
            return nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);       
        }
    }
}
