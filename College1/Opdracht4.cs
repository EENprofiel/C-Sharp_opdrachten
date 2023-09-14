namespace C_Sharp_opdrachten.College1
{
    public class Opdracht4
    {
        public static void Execute()
        {
            // Definieer de minimale en maximale geldige getallen
            int min = 1;
            int max = 10;
            int userInput; // Variabele om de gebruikersinvoer op te slaan

            Console.WriteLine("Voer een getal in tussen 1 en 10:");

            // Start een do-while-lus om gebruikersinvoer te blijven vragen totdat deze geldig is
            do
            {
                Console.Write("Invoer: ");

                // Lees de invoer van de gebruiker en probeer deze te converteren naar een integer
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    // Controleer of de invoer binnen het geldige bereik ligt
                    if (userInput >= min && userInput <= max)
                    {
                        Console.WriteLine($"Je hebt {userInput} ingevoerd. Dit is een geldig getal.");
                    }
                    else
                    {
                        Console.WriteLine("Ongeldig getal. Voer een getal in tussen 1 en 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                }
            } while
                (userInput < min || userInput > max); // Ga door de lus zolang de invoer buiten het geldige bereik ligt

            Console.WriteLine("Bedankt voor de juiste invoer!");
        }
    }
}