using System.Security.Cryptography;

namespace C_Sharp_opdrachten.College3;

public class Opdracht1
{
    public static void Execute()
    {
        List<int> randomGetallen = new();
        Random random = new();
        
        // unsorted
        for (int i = 0; i < 10; i++)
        {
            randomGetallen.Add(random.Next(0,100));
            Console.WriteLine($"Random getal #{i+1}: {randomGetallen[i]}");
        }
        Console.WriteLine();
        

        // sorted
        randomGetallen.Sort();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Sorted: Random getal #{i+1}: {randomGetallen[i]}");
        }
        Console.WriteLine();


        // reversed
        randomGetallen.Reverse();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Reversed: Random getal #{i+1}: {randomGetallen[i]}");
        }
        Console.WriteLine();

        // delete even numbers
        // van achter naar voren itereren dan mag je altijd elementen verwijderen. in tegenstelling tot van voor naar achteren dat het steeds errors geeft.
        // int x = 1;
        // foreach (int getal in randomGetallen.ToArray()) 
        // {
        //     if (getal % 2 == 0)
        //     {
        //         // Console.WriteLine($"GETAL {getal} IS EVEN");
        //         randomGetallen.Remove(getal);
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Without even numbers: Random getal #{x}: {getal}");
        //         x++;
        //     }
        // }
        
        // docent oplossing
        randomGetallen.RemoveAll(x => x % 2 == 0);
        int x = 1;
        foreach (int nummer in randomGetallen)
        {
            Console.WriteLine($"Without even numbers: Random getal #{x}: {nummer}");
            x++;
        }
        Console.WriteLine();
    }
}