namespace girrafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("teste");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            string tome = "teste formatacoes disponiveis";
            Console.WriteLine(tome.First() + tome.ToUpper() + tome.ToLower());
        }
    }
}