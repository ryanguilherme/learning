﻿namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string? option;
            while (true)
            {
                Console.WriteLine("Escolha uma operacao: +, -, *, /");
                option = Console.ReadLine();
                if (option == "+")
                {
                    Console.Write("Digite um numero: ");
                    int a = Console.Read();
                    Console.Write("Digite outro numero para somar: ");
                    int b = Console.Read();
                    Console.WriteLine();
                    Console.WriteLine($"{a} + {b} = {a+b}");
                }
                else if (option == "-")
                {
                    Console.Write("Digite um numero: ");
                    int a = Console.Read();
                    Console.Write("Digite outro numero para subtrair: ");
                    int b = Console.Read();
                    Console.WriteLine($"{a} - {b} = {a - b}");
                }
                else if (option == "*")
                {
                    Console.Write("Digite um numero: ");
                    int a = Console.Read();
                    Console.Write("Digite outro numero para multiplicar");
                    int b = Console.Read();
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
                else if (option == "/")
                {
                    Console.Write("Digite um numero: ");
                    int a = Console.Read();
                    Console.Write("Digite outro numero para dividir: ");
                    int b = Console.Read();
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
                else
                {
                    Console.WriteLine("Encerrando...");
                    break;
                }
            }
        }
    }
}