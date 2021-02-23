using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            // Elabore um programa em console, c#, e requisite ao operador um valor numérico. faça uma rotina para verificar se o número é par ou ímpar, imprima o resultado no console.

            int getValue = 0;
            int valueAux = 0;

            Console.Write("Digite um valor inteiro para saber se o número é impar ou par: ");
            getValue = int.Parse(Console.ReadLine());

            while (getValue < 0) {
                Console.Write("Por favor, insira um número maior que 0: ");
                getValue = int.Parse(Console.ReadLine());
            }

            valueAux = getValue % 2;
            Console.Write( (valueAux == 1) ? "O número " + getValue + " é impar" : "O número " + getValue + " é par" );
            Console.ReadKey();
            
        }
    }
}
