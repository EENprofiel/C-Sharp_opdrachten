namespace C_Sharp_opdrachten.College1
{
    public class Opdracht5
    {
        public static void Execute()
        {
            // Itereert over de getallen van 0 tot 99
            for (int i = 0; i < 100; i++)
            {
                // Bepaalt welke tekst moet worden afgedrukt
                // **Deze if-statement controleert of het getal deelbaar is door 3 en 5.**
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    // "FizzBuzz" afdrukken
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    // **Deze if-statement controleert of het getal alleen deelbaar is door 5.**
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    // **Deze if-statement controleert of het getal alleen deelbaar is door 3.**
                    Console.WriteLine("Fizz");
                }
                else
                {
                    // **Deze if-statement controleert of het getal niet deelbaar is door 3 of 5.**
                    // Het getal zelf afdrukken
                    Console.WriteLine(i);
                }
            }
        }
    }
}