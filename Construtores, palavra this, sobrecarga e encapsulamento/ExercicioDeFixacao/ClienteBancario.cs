using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacao
{
    class ClienteBancario
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ClienteBancario(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0; // Não é preciso, apenas enfatizei.
        }
        public ClienteBancario(int numeroConta, string nome, double depositoInicial): this(numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Saque (double valor)
        {
            Saldo = Saldo - valor -5;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Conta "+NumeroConta+", Titular: "+Nome+", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
