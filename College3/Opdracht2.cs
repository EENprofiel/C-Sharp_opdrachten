﻿namespace C_Sharp_opdrachten.College3;

// nog niet af
public class Opdracht2
{
    public static void Execute()
    {
        Dictionary<string, int> studenten = new();
        studenten.Add("Jantje", 1183210);
        studenten.Add("Sjonnie", 1183211);
        studenten.Add("Ronnie", 1183212);
        studenten.Add("Donnie", 1183213);
        studenten.Add("Lolly", 1183214);

        // student zoeken op naam
        foreach (var student in studenten)
        {
            if (student.Key.Equals("Jantje"))
            {
                Console.WriteLine($"Studentennaam: {student.Key}");
                Console.WriteLine($"Studentnummer: {student.Value}");
            }
        }

        // student verwijderen op naam
        studenten.Remove("Jantje");

        foreach (var student in studenten)
        {
            Console.WriteLine($"Studentennaam: {student.Key}");
            Console.WriteLine($"Studentnummer: {student.Value}");
            Console.WriteLine();
        }
    }
}