namespace C_Sharp_opdrachten.College1
{
    public class Opdracht7
    {
        public static void Execute()
        {
            // De huidige priemgetalteller
            int priemgetallenteller = 0;

            // De huidige getalwaarde
            int getal = 2;

            // Zolang we nog geen 10 priemgetallen hebben gevonden...
            while (priemgetallenteller < 10)
            {
                // Controleer of het getal priem is
                bool isPriem = true;
                for (int i = 2; i <= getal / 2; i++)
                {
                    if (getal % i == 0)
                    {
                        isPriem = false;
                        break;
                    }
                }

                // Als het getal priem is, print het af
                if (isPriem)
                {
                    Console.WriteLine(getal);
                    priemgetallenteller++;
                }

                // Ga naar het volgende getal
                getal++;
            }
        }
    }
}