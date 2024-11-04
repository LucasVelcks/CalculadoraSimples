using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Calculadora");
            Console.WriteLine("Digite um numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha o operador (+, -, *, /): ");
            char operador = Console.ReadLine()[0];

            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Erro: Divisão por zero inválida!");
                    break;
                default:
                    Console.WriteLine("Operador invalido!");
                    return;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
