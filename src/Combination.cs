namespace AtmCartridges
{
    public class Combination
    {
        public static List<List<int>> Get(int amount, int tens, int fifties, int hundreds)
        {
            List<List<int>> combinations = new List<List<int>>();

            if ((amount % 100 == 0) && (amount / 100 <= hundreds))
            {
                combinations.Add(new List<int> { amount / 100, 0, 0 });
            }

            for (int hu = 0; hu <= Math.Min(hundreds, amount / 100); hu++)
            {
                int remainingAmount = amount - hu * 100;
                for (int fi = 0; fi <= Math.Min(fifties, (remainingAmount / 50)); fi++)
                {
                    remainingAmount = amount - hu * 100 - fi * 50;
                    for (int te = 0; te <= Math.Min(tens, remainingAmount / 10); te++)
                    {
                        if (remainingAmount == (te * 10))
                        {
                            combinations.Add(new List<int> { hu, fi, te });
                        }
                    }
                }
            }

            return combinations;
        }
    }
}
