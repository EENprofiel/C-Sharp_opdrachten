namespace C_Sharp_opdrachten.College1
{
    public class Opdracht3
    {
        public static void Execute()
        {
            // Genereer een willekeurig getal tussen 1 en 99 met behulp van de Random.Shared.Next-methode
            int RandomNumber = Random.Shared.Next(1, 99 + 1);

            // Geef een welkomstboodschap aan de gebruiker
            Console.WriteLine("Welkom bij het hoger-lager spel!");
            Console.WriteLine("Probeer het geheime getal te raden tussen 1 en 99.");

            // Start een oneindige lus om het spel voort te zetten totdat de gebruiker het juiste getal raadt
            while (true)
            {
                // Lees de invoer van de gebruiker en probeer deze te converteren naar een integer
                int.TryParse(Console.ReadLine(), out int cijfer);

                // Controleer of de invoer buiten het bereik van 1 tot 99 valt
                if (cijfer < 1 || cijfer > 99)
                {
                    Console.WriteLine("Verkeerde invoer. Probeer het opnieuw.");
                }
                // Als de invoer lager is dan het geheime getal, geef een boodschap dat het geheime getal hoger is
                else if (cijfer > RandomNumber)
                {
                    Console.WriteLine("Geheime getal is lager dan jouw gok.");
                }
                // Als de invoer hoger is dan het geheime getal, geef een boodschap dat het geheime getal lager is
                else if (cijfer < RandomNumber)
                {
                    Console.WriteLine("Geheime getal is hoger dan jouw gok.");
                }
                // Als de invoer gelijk is aan het geheime getal, geef een succesbericht en stop de lus
                else
                {
                    Console.WriteLine("Geraden!!!!");
                    break;
                }

                // Laat de gebruiker weten dat ze opnieuw moeten proberen als de gok niet correct is
                Console.WriteLine("Probeer het opnieuw!");
            }

            // Bedank de gebruiker voor het spelen wanneer het spel is voltooid
            Console.WriteLine("Dank je wel voor het spelen!");
        }
    }
}