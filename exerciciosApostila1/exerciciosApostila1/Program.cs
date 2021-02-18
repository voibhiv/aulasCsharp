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
            
            // Inicialization 
            double firstValue  = 0;
            double secondValue = 0;
            double resultReq   = 0;

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
            // ====================================================================================================================================================

            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Escreva um programa em console, c#, e requisite ao operador o nome, o sexo, o peso, a altura e data de nascimento. Como resultado imprima no console os seguintes resultados:");

            string nomeBmc   = "";
            string genreBmc  = "";
            string dateBmc   = "";
            double ageBmc    =  0;
            double heightBmc =  0;
            double weightBmc =  0;
            double resultBmc =  0;


            // Get value relative of the name
            Console.WriteLine("Digite seu nome: ");
            nomeBmc = Console.ReadLine();

            // Get value relative of the genre
            Console.WriteLine("Digite seu sexo: (M) -- (F)");
            genreBmc = Console.ReadLine();

            while ((genreBmc != "M") && (genreBmc != "F")) {
                // Get value relative of the genre
                Console.WriteLine("Digite seu sexo: ");
                genreBmc = Console.ReadLine();
            }

            // Get value relative of the date
            Console.WriteLine("Digite a data de nascimento (DD/MM/YYYY) : ");
            dateBmc = Console.ReadLine();

            // Get value relative of the weight
            Console.WriteLine("Digite seu peso: ");
            weightBmc = double.Parse(Console.ReadLine());

            // Get value relative of the height
            Console.WriteLine("Digite sua altura: ");
            heightBmc = double.Parse(Console.ReadLine());

            // Get value relative of the age
            Console.WriteLine("Digite sua idade: ");
            ageBmc = double.Parse(Console.ReadLine());

            resultBmc = weightBmc / (heightBmc * heightBmc);

            Console.WriteLine("Olá " + nomeBmc + " declarado como" + (genreBmc == "M" ? " Masculino" : "Feminino") + " nascido em " + dateBmc + ", sua idade é de: " + ageBmc + " e seu BMC(IMC) é de: " + resultBmc);
            if (resultBmc < 17) {
                Console.WriteLine("==> Você está muito abaixo do peso.");
            } else if (resultBmc >= 17 && resultBmc <= 18.49) {
                Console.WriteLine("==> Você está abaixo do peso.");
            } else if (resultBmc >= 18.5 && resultBmc <= 24.99) {
                Console.WriteLine("==> Você está no peso normal.");
            } else if (resultBmc >= 25 && resultBmc <= 29.99) {
                Console.WriteLine("==> Você está acima do peso.");
            } else if (resultBmc >= 30 && resultBmc <= 34.99) {
                Console.WriteLine("==> Você está com obesidade nível 1.");
            } else if (resultBmc >= 35 && resultBmc <= 39.99) {
                Console.WriteLine("==> Você está com obesidade nível 2.");
            } else if (resultBmc > 40) {
                Console.WriteLine("==> Você está com obesidade nível 3.");
            }

            Console.ReadKey();
        }
    }
}
