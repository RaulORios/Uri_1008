using System;
using System.Globalization;

namespace Uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double salario_Hora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario_Hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * salario_Hora;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
