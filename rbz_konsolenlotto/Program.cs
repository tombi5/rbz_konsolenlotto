namespace rbz_konsolenlotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lottoTipp = { 1, 2, 3, 4, 5, 6 };
            int[] lottoZahlen = new int[6];
            Random random = new Random();

            for (int i = 0; i < lottoZahlen.Length; i++)
            {
                lottoZahlen[i] = random.Next(1, 50);
            }

            int treffer = 0;

            for (int i = 0; i < lottoTipp.Length; i++)
            {
                for (int j = 0; j < lottoZahlen.Length; j++)
                {
                    if (lottoTipp[i] == lottoZahlen[j])
                    {
                        treffer++;
                        Console.WriteLine("Treffer: " + lottoTipp[i]);
                    }
                }
            }

            Console.WriteLine("Anzahl der Treffer: " + treffer);

            // Zusatzaufgaben
            Console.WriteLine("Bitte geben Sie sechs unterschiedliche Lottozahlen zwischen 1 und 49 ein:");
            int[] lottoTippEingabe = new int[6];

            for (int i = 0; i < lottoTippEingabe.Length; i++)
            {
                lottoTippEingabe[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool validTipp = true;

            for (int i = 0; i < lottoTippEingabe.Length; i++)
            {
                if (lottoTippEingabe[i] < 1 || lottoTippEingabe[i] > 49)
                {
                    validTipp = false;
                    break;
                }

                for (int j = i + 1; j < lottoTippEingabe.Length; j++)
                {
                    if (lottoTippEingabe[i] == lottoTippEingabe[j])
                    {
                        validTipp = false;
                        break;
                    }
                }

                if (!validTipp)
                {
                    break;
                }
            }

            if (validTipp)
            {
                Array.Sort(lottoZahlen);
                Console.WriteLine("Lottozahlen aufsteigend sortiert:");
                foreach (int zahl in lottoZahlen)
                {
                    Console.WriteLine(zahl);
                }
            }
            else
            {
                Console.WriteLine("Ungültige Tipp-Eingabe!");
            }
        }
    }
}