namespace C_Sharp_opdrachten.College1
{
    public class Opdracht1
    {
        public static void Execute()
        {
            // Vraag de gebruiker om een getal in te voeren
            Console.WriteLine("Voer een getal in: ");
            string invoer = Console.ReadLine();

            // Probeer de ingevoerde waarde te converteren naar een integer
            if (int.TryParse(invoer, out int nummer))
            {
                // Gebruik een switch statement om het ingevoerde getal te evalueren
                switch (nummer)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Slecht"); // Toon "Slecht" voor 1, 2 of 3
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Matig"); // Toon "Matig" voor 4 of 5
                        break;
                    case 6:
                        Console.WriteLine("Voldoende"); // Toon "Voldoende" voor 6
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Goed"); // Toon "Goed" voor 7 of 8
                        break;
                    case 9:
                        Console.WriteLine("Uitstekend"); // Toon "Uitstekend" voor 9
                        break;
                    default:
                        Console.WriteLine(
                            "Getal zit buiten het bereik van dit programma"); // Toon een bericht als het getal buiten het bereik ligt
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ongeldige invoer"); // Toon "Ongeldige invoer" als de invoer geen geldig getal is
            }
        }
    }
}