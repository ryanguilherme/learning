namespace recursion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero de vezes que voce quer eleva-lo: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int res = pow(n, m);
            Console.WriteLine($"{n} elevado a {m} = {res}");
        }

        public static int pow(int n, int m)
        {
            if (m == 0)
            {
                return 1;
            }
            return n * pow(n, m - 1);
        }
    }
}