namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string? option;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma operacao: +, -, *, /, ou ENTER para encerrar");
                option = Console.ReadLine();
                if (option == "+")
                {
                    Console.Write("Digite um numero: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite outro numero para somar: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"{a} + {b} = {a+b}");
                }
                else if (option == "-")
                {
                    Console.Write("Digite um numero: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite outro numero para subtrair: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} - {b} = {a - b}");
                }
                else if (option == "*")
                {
                    Console.Write("Digite um numero: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite outro numero para multiplicar");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
                else if (option == "/")
                {
                    Console.Write("Digite um numero: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite outro numero para dividir: ");
                    int b = Convert.ToInt32(Console.ReadLine());
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