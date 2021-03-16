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

                    Console.WriteLine("================================================");
                    break;

                case 2:
                    Console.WriteLine("================================================");
                    Console.WriteLine("Exercício 2");
                    Console.WriteLine("Elabore um programa que requisite ao operador 3 números. Desenvolva uma rotina que encontre o menor número e imprima-o no console." +
                        " Valide para que nenhum número seja igual ao outro.");

                    int valueAux2 = 0;
                    int value1 = 0;
                    int value2 = 0;
                    int value3 = 0;

                    Console.Write("Digite o primeiro valor: ");
                    value1 = int.Parse(Console.ReadLine());

                    valueAux2 = value1;

                    Console.Write("Digite o segundo valor: ");
                    value2 = int.Parse(Console.ReadLine());
                    while (value2 == value1) {
                        Console.Write("Digite o segundo valor que seja diferente do primeiro: ");
                        value2 = int.Parse(Console.ReadLine());
                    }

                    valueAux2 = (value2 < valueAux2) ? value2 : valueAux2;

                    Console.Write("Digite o terceiro valor: ");
                    value3 = int.Parse(Console.ReadLine());
                    while (value3 == value1 || value3 == value2) {
                        Console.Write("Digite o terceiro valor que seja diferente dos outros: ");
                        value3 = int.Parse(Console.ReadLine());
                    }

                    valueAux2 = (value3 < valueAux2) ? value3 : valueAux2;
                    Console.WriteLine("================================================");
                    Console.WriteLine("O menor valor digitado foi: " + valueAux2);

                    break;

                case 3:
                    Console.WriteLine("================================================");
                    Console.WriteLine("Elaborar um programa para receber a pontuação de duas notas. Se a média for maior que 7," +
                    " o programa deverá escrever a mensagem Parabéns você aprovou com a nota X, ou, Sua nota foi X e você foi Reprovado! ");

                    int nota1 = 0;
                    int nota2 = 0;
                    double notaTotal = 0;

                    Console.WriteLine("Digite o valor da primeira nota: ");
                    nota1 = int.Parse(Console.ReadLine());

                    while (nota1 < 0 || nota1 > 10) {
                        Console.WriteLine("Valor incorreto! Digite o valor da primeira nota: ");
                        nota1 = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Digite o valor da segunda nota: ");
                    nota2 = int.Parse(Console.ReadLine());

                    while (nota2 < 0 || nota2 > 10) {
                        Console.WriteLine("Valor incorreto! Digite o valor da segunda nota: ");
                        nota2 = int.Parse(Console.ReadLine());
                    }

                    notaTotal = ( (nota1 + nota2) / 2 );

                    if (notaTotal >= 7) {
                        Console.WriteLine("Parabéns você aprovou com a nota: " + notaTotal);
                    } else {
                        Console.WriteLine("Parabéns você reprovou com a nota: " + notaTotal);
                    }

                    break;

            }

            Console.ReadKey();
        }
    }
}
