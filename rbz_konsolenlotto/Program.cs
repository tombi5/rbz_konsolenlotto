namespace rbz_konsolenlotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lottoTipp = { 1, 2, 3, 4, 5, 6 };
            int[] lottoZahlen = new int[6];
            Random random = new Random();

            for (int i = 0; i < lottoTipp.Length; i++)
            {
                Console.Write("Zahl zwischen 1-49 " + (i + 1) + ": ");
                string input = Console.ReadLine();
                int number;
                if (int.TryParse(input, out number))
                {
                    lottoTipp[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalider input. Versuche es nochmal.");
                    i--;
                }
            }

            for (int i = 0; i < lottoZahlen.Length; i++)
            {
                lottoZahlen[i] = random.Next(1, 50);
            }

            int treffer = 0;

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

            // Zusatzaufgaben
            // 4. Lesen Sie sechs frei gewählte Lottozahlen über die Konsole in das Array lottoTipp ein, statt diese wie in Aufgabe 1 als int-Literale festzulegen.
            // 5. Überprüfen Sie, dass der Tippgeber (Zufallsgenerator oder User) sechs unterschiedliche Zahlen zwischen 1 und 49 zieht (Dopplungen nicht zulassen).
            // 6. Recherchieren Sie, wie Sie das Array lottoZahlen aufsteigend sortieren können.
            
        }
    }
}