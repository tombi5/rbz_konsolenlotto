namespace rbz_konsolenlotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int treffer = 0;
            int[] lottoTipp = new int[6];
            int[] lottoZahlen = new int[6];
            Random random = new Random();

            for (int i = 0; i < lottoTipp.Length; i++)
            {
                Console.Write("Zahl zwischen 1-49 " + (i + 1) + ": ");
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number))
                {
                    if (number >= 1 && number <= 49 && !lottoTipp.Contains(number))
                    {
                        lottoTipp[i] = number;
                    }
                    else
                    {
                        Console.WriteLine("Falscher input. Versuche es nochmal.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Falscher input. Versuche es nochmal.");
                    i--;
                }
            }

            for (int i = 0; i < lottoZahlen.Length; i++)
            {
                lottoZahlen[i] = random.Next(1, 50);
            }

            for (int i = 0; i < lottoZahlen.Length; i++)
            {
                for (int j = 0; j < lottoTipp.Length; j++)
                {
                    if (lottoZahlen[i] == lottoTipp[j])
                    {
                        treffer++;
                        Console.WriteLine("Treffer: " + lottoZahlen[i]);
                    }
                }
            }

            Console.WriteLine("Anzahl der Treffer: " + treffer);
            Array.Sort(lottoZahlen);
            Console.WriteLine("Lottozahlen: " + string.Join(", ", lottoZahlen));


        }
    }
}