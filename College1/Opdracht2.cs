namespace C_Sharp_opdrachten.College1
{
    public class Opdracht2
    {
        // Dit is een openbare (public) methode genaamd "Execute" die kan worden aangeroepen vanuit andere delen van het programma.
        public static void Execute()
        {
            // Vraag de gebruiker om een cijfer in te voeren tussen 1,0 en 10,0
            Console.WriteLine("Voer een cijfer in (1,0 t/m 10,0):");

            // Lees de invoer van de gebruiker en probeer het om te zetten naar een dubbel (double) cijfer.
            if (double.TryParse(Console.ReadLine(), out double cijfer))
            {
                // Controleer in welke bereik het ingevoerde cijfer valt en geef de bijbehorende tekstuele beoordeling.
                if (cijfer >= 1.0 && cijfer < 4.0)
                {
                    Console.WriteLine("Slecht");
                }
                else if (cijfer >= 4.0 && cijfer < 5.5)
                {
                    Console.WriteLine("Matig");
                }
                else if (cijfer >= 5.5 && cijfer < 7.0)
                {
                    Console.WriteLine("Voldoende");
                }
                else if (cijfer >= 7.0 && cijfer < 8.5)
                {
                    Console.WriteLine("Goed");
                }
                else if (cijfer >= 8.5 && cijfer <= 10.0)
                {
                    Console.WriteLine("Uitstekend");
                }
                else
                {
                    // Toon een foutmelding als het ingevoerde cijfer buiten het verwachte bereik ligt.
                    Console.WriteLine("Ongeldige invoer. Voer een cijfer tussen 1,0 en 10,0 in.");
                }
            }
            else
            {
                // Toon een foutmelding als de invoer geen geldig cijfer is.
                Console.WriteLine("Ongeldige invoer. Voer een geldig cijfer in.");
            }
        }
    }
}