using System;

namespace exerciciosApostila1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ====================================================================================================================================================

            Console.WriteLine("Exercício 1");
            Console.WriteLine("Elabore um programa em console, C#, para calcular a resistência equivalente entre dois registros R1 e R2 em paralelo. ");
            Console.WriteLine("======================================================================================================================");
            
            double firstValue = 0;
            double secondValue = 0;
            double resultReq = 0;

            // Get first value of console
            Console.Write("Digite o valor de R1: ");
            firstValue = double.Parse(Console.ReadLine());
            // Get second value of console
            Console.Write("Digite o valor de R2: ");
            secondValue = double.Parse(Console.ReadLine());

            // Calculate and showing result
            resultReq = (firstValue * secondValue) / (firstValue + secondValue);
            Console.WriteLine("O valor de req é : " + resultReq + " ohms");
            Console.WriteLine("======================================================================================================================");
            // ====================================================================================================================================================

            Console.WriteLine("Exercício 2");
            Console.WriteLine("Escreva um programa em console, c#, para calcular a distância entre dois pontos (x1, y1) e (x2, y2) no plano cartesiano. ");
            Console.WriteLine("======================================================================================================================");

            // Inicialization variables
            double valueX1 = 0;
            double valueX2 = 0;
            double valueY1 = 0;
            double valueY2 = 0;
            double result  = 0;

            // Get first value (X1) of console
            Console.Write("Digite o valor de X1: ");
            valueX1 = double.Parse(Console.ReadLine());
            // Get second value (X2) of console
            Console.Write("Digite o valor de X2: ");
            valueX2 = double.Parse(Console.ReadLine());
            // Get first value  (Y1) of console
            Console.Write("Digite o valor de Y1: ");
            valueY1 = double.Parse(Console.ReadLine());
            // Get second value (Y2) of console
            Console.Write("Digite o valor de Y1: ");
            valueY2 = double.Parse(Console.ReadLine());

            // Calculate and showing result
            result = ( ((valueX1 - valueX2) * (valueX1 - valueX2)) + ((valueY1 - valueY2) * (valueY1 - valueY2)) );
            result = Math.Sqrt(result);
            Console.WriteLine("A distância dos pontos é de: " + result);
            Console.WriteLine("======================================================================================================================");
            Console.ReadKey();
        }
    }
}
