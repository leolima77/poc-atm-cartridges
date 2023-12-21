namespace AtmCartridges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] amounts = { 30, 50, 60, 80, 140, 230, 370, 610, 980 };
            int tens = 10, fifties = 5, hundreds = 2;

            foreach (int amount in amounts)
            {
                List<List<int>> combinations = Combination.Get(amount, tens, fifties, hundreds);
                Console.WriteLine($"Amount: {amount}");

                foreach (List<int> combination in combinations)
                {
                    Console.WriteLine($"\t- {combination[0]} x 100 EUR | {combination[1]} x 50 EUR | {combination[2]} x 10 EUR");
                }
                Console.WriteLine("---");
            }
        }
    }
}