using System;
using System.Collections.Generic;
using System.Text;

namespace treino_circunferencia {
    class Calculadora {

        public static double iof = 6.0;

        public static double ConversorDeMoeda(double d, double q) {
            double total = d * q;
            return total + total * iof / 100;
        }
    }
}
