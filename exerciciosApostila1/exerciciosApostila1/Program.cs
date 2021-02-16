using System;

namespace exerciciosApostila1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue = 0;
            double secondValue = 0;
            double resultReq = 0;
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Elabore um programa em console, C#, para calcular a resistência equivalente entre dois registros R1 e R2 em paralelo. ");
            Console.WriteLine("======================================================================================================================");

            Console.Write("Digite o valor de R1: ");
            firstValue = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de R2: ");
            secondValue = double.Parse(Console.ReadLine());

            resultReq = (firstValue * secondValue) / (firstValue + secondValue);
            Console.WriteLine("======================================================================================================================");
            Console.Write("O valor de req é : " + resultReq + " ohms");
            Console.ReadKey();
        }
    }
}
