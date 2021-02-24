using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int getMenu = 0;

            Console.WriteLine("================================================");
            Console.WriteLine("============ ESCOLHA UM O EXERCICIO ============");
            Console.WriteLine("-----> CONDIÇÃO IF ");
            Console.WriteLine("1º Exercício ");
            Console.WriteLine("2º Exercício ");
            Console.WriteLine("3º Exercício ");
            Console.WriteLine("4º Exercício ");
            Console.WriteLine("-----> CONDIÇÃO FOR LOOP ");
            Console.WriteLine("5º Exercício ");
            Console.WriteLine("6º Exercício ");
            Console.WriteLine("7º Exercício ");
            Console.WriteLine("8º Exercício ");
            Console.WriteLine("9º Exercício ");
            Console.WriteLine("================================================");
            getMenu = int.Parse(Console.ReadLine());

            while (getMenu > 9 || getMenu < 0) {
                Console.WriteLine("VALOR INVÁLIDO POR FAVOR ESCOLHA UM NÚMERO DE 1 A 9");
                Console.WriteLine("================================================");
                Console.WriteLine("============ ESCOLHA UM O EXERCICIO ============");
                Console.WriteLine("-----> CONDIÇÃO IF ");
                Console.WriteLine("1º Exercício ");
                Console.WriteLine("2º Exercício ");
                Console.WriteLine("3º Exercício ");
                Console.WriteLine("4º Exercício ");
                Console.WriteLine("-----> CONDIÇÃO FOR LOOP ");
                Console.WriteLine("5º Exercício ");
                Console.WriteLine("6º Exercício ");
                Console.WriteLine("7º Exercício ");
                Console.WriteLine("8º Exercício ");
                Console.WriteLine("9º Exercício ");
                Console.WriteLine("================================================");
                getMenu = int.Parse(Console.ReadLine());
            }

            switch (getMenu) {
                case 1:
                    Console.WriteLine("================================================");
                    Console.WriteLine("Exercício 1");
                    Console.WriteLine("Elabore um programa em console, c#, e requisite ao operador um valor numérico. " +
                        "faça uma rotina para verificar se o número é par ou ímpar, imprima o resultado no console.");

                    int getValue = 0;
                    int valueAux = 0;

                    Console.Write("Digite um valor inteiro para saber se o número é impar ou par: ");
                    getValue = int.Parse(Console.ReadLine());

                    while (getValue < 0) {
                        Console.Write("Por favor, insira um número maior que 0: ");
                        getValue = int.Parse(Console.ReadLine());
                    }

                    valueAux = getValue % 2;
                    Console.Write((valueAux == 1) ? "O número " + getValue + " é impar" : "O número " + getValue + " é par");
                    Console.ReadKey();

                    Console.WriteLine("================================================");
                break;
            }


        }
    }
}
