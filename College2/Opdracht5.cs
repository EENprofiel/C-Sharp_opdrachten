namespace C_Sharp_opdrachten.College2;

public class Opdracht5
{
    public static class ConfigurationData
    {
        private static string _applicatieNaam { get; }
        private static string _versie { get; }
        private const int _maxAantalGebruikers = 100;

        static ConfigurationData()
        {
            _applicatieNaam = "Minecraft";
            _versie = "0.1a";
        }

        public static string Print() =>
            $"Applicatienaam: {_applicatieNaam} | Versie: {_versie} | Maximale aantal gebruikers: {_maxAantalGebruikers}";
    }

    public static void Execute()
    {
        Console.WriteLine(ConfigurationData.Print());
    }
}