namespace C_Sharp_opdrachten.College3;

public class Opdracht3
{
    public static void Execute()
    {
        List<int> getallen = new();
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            getallen.Add(rand.Next(0, 100));
            Console.WriteLine(getallen[i]);
        }

        var evenGetallen =
            from getal in getallen
            where getal % 2 == 0
            select getal;

        foreach (var evenGetal in evenGetallen)
        {
            Console.WriteLine($"Even getallen: {evenGetal}");
        }
    }
}