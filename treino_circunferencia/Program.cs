using System;
using System.Globalization;
using System.Transactions;

namespace treino_circunferencia {
    class Program {
        static void Main(string[] args) {

            double dolar;
            int quantidade;

            Calculadora calc = new Calculadora();

            Console.Write("Digite o valor do dólar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares irá comprar?: ");
            quantidade = int.Parse(Console.ReadLine());

            double valor = Calculadora.ConversorDeMoeda(dolar, quantidade);

            Console.WriteLine("Valor à ser pago em reais: " + valor.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
