using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFinalStatico
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ConversorMoeda(double qtd, double cot)
        {
            double total = qtd * cot;
            total = total + (total * Iof);
            return total;
        }
    }
}
