using System.Net.Sockets;

namespace C_Sharp_opdrachten.College2;

public class Opdracht3
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        public static double Sub(double a, double b)
        {
            return (a - b);
        }
    }

    public static void Execute()
    {
        Console.WriteLine(Calculator.Add(5, 5));
        Console.WriteLine(Calculator.Sub(5, 5));
    }
}