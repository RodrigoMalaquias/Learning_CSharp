using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Schema;

namespace Exercicio_3
{
    class Aluno
    {
        public string Nome;
        public double NotaPrimeiro;
        public double NotaSegundo;
        public double NotaTerceiro;
        public double total;

        public void aprovacao()
        {
            total = NotaPrimeiro + NotaSegundo + NotaTerceiro;

            if ((total) >= 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + total.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + total.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM "+ (60.00-total).ToString("F2",CultureInfo.InvariantCulture)+" PONTOS");
            }
        }
    }
}
