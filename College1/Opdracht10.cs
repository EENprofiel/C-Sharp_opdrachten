namespace C_Sharp_opdrachten.College1
{
    public class Opdracht10
    {
        public static void Execute()
        {
            {
                int score = 0; // Houdt de score bij

                // Array met vragen en antwoordkeuzes
                string[] vragen =
                {
                    "1. Wat is de hoofdstad van Frankrijk?",
                    "2. Hoeveel planeten heeft ons zonnestelsel?",
                    "3. Wat is de grootste planeet in ons zonnestelsel?",
                    "4. Wie schilderde de Mona Lisa?",
                    "5. Wat is de hoogste berg ter wereld?"
                };

                string[][] antwoorden =
                {
                    new string[] { "a) Parijs", "b) Londen", "c) Berlijn" },
                    new string[] { "a) 7", "b) 8", "c) 9" },
                    new string[] { "a) Aarde", "b) Mars", "c) Jupiter" },
                    new string[] { "a) Leonardo da Vinci", "b) Vincent van Gogh", "c) Pablo Picasso" },
                    new string[] { "a) Mount Kilimanjaro", "b) Mount Everest", "c) Mount McKinley" }
                };

                // Array met de juiste antwoorden
                char[] juisteAntwoorden = { 'a', 'b', 'c', 'a', 'b' };

                Console.WriteLine("Welkom bij de quiz! Beantwoord de volgende vragen:");

                // Loop om de vragen te stellen en de antwoorden te controleren
                for (int i = 0; i < vragen.Length; i++)
                {
                    Console.WriteLine(vragen[i]);

                    // Druk de antwoordkeuzes af
                    for (int j = 0; j < antwoorden[i].Length; j++)
                    {
                        Console.WriteLine(antwoorden[i][j]);
                    }

                    Console.Write("Jouw antwoord: ");
                    char antwoord = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    // Controleer of het antwoord correct is en verhoog de score indien nodig
                    if (antwoord == juisteAntwoorden[i])
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Fout! Het juiste antwoord is: " + juisteAntwoorden[i] + "\n");
                    }
                }

                // Toon de eindscore
                Console.WriteLine("Je hebt " + score + " van de 5 vragen correct beantwoord.");
            }
        }
    }
}