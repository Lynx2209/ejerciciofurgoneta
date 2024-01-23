namespace ejerciciofurgoneta
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cuanto pesa tu saco");
            int pesodelSaco = Convert.ToInt32(Console.ReadLine());

            int numerodelSacoMax = 4000 / pesodelSaco;
            Console.WriteLine(numerodelSacoMax);
        }
    }
}