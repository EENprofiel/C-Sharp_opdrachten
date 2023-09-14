namespace C_Sharp_opdrachten.College1
{
    public class Opdracht9
    {
        public static void Execute()
        {
            Console.WriteLine("Voer een getal in: ");
            string invoer = Console.ReadLine();

            // Gebruik van de ternaire operator om het resultaat te bepalen
            string resultaat = int.TryParse(invoer, out int nummer)
                ? (nummer >= 0 && nummer <= 49) ? "Slecht" : // Als nummer tussen 0 en 49 is
                (nummer >= 50 && nummer <= 59) ? "Matig" : // Als nummer tussen 50 en 59 is
                (nummer >= 60 && nummer <= 74) ? "Voldoende" : // Als nummer tussen 60 en 74 is
                (nummer >= 75 && nummer <= 89) ? "Goed" : // Als nummer tussen 75 en 89 is
                (nummer >= 90 && nummer <= 100) ? "Uitstekend" : // Als nummer tussen 90 en 100 is
                "Getal zit buiten het bereik van dit programma" // Anders
                : "Ongeldige invoer"; // Als het geen geldige integer is

            // Druk het resultaat af
            Console.WriteLine(resultaat);
        }
    }
}