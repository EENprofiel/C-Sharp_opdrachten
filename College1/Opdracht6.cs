namespace C_Sharp_opdrachten.College1
{
    public class Opdracht6
    {
        public static void Execute()
        {
            // Een lijst van namen maken
            List<string> namen = new List<string>
            {
                "Anna",
                "Bob",
                "Charlie",
                "Dave",
                "Eva",
                "Frank",
                "Grace",
                "Harry",
                "Ivy",
                "Jack"
            };

            // Voor elke naam in de lijst itereren
            foreach (string naam in namen)
            {
                // Als de naam korter is dan 5 letters, afdrukken
                // **Deze if-statement controleert of de naam korter is dan 5 letters.**
                if (naam.Length < 5)
                {
                    // De naam afdrukken
                    Console.WriteLine(naam);
                }
            }
        }
    }
}