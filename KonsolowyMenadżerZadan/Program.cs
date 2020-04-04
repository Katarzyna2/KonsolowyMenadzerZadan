using System;
using System.Collections.Generic;

namespace KonsolowyMenadżerZadan
{
    class Program
    {
        public class Aplikacja
        {
            public Aplikacja(string zadanie, string datazadania)
            {
                Zadanie = zadanie;
                DataZadania = datazadania;
            }

            public string Zadanie { get; set; }
            public string DataZadania { get; set; }
        }
        static void Main(string[] args)
        {
            List<Aplikacja> zadania = new List<Aplikacja>();
            string command = "";

            do
            {
                Console.WriteLine("Czekam na polecenie:");
                command = Console.ReadLine();
                Console.WriteLine();

                if (command.ToUpper().Trim() == "ADD")
                {
                    Console.Write("Dodaj zadanie: ");
                    string zadanie = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Podaj datę zadania: ");
                    string DataZadania = Console.ReadLine();
                    Console.WriteLine();

                    bool parseResult = DateTime.TryParse(DataZadania, out var d);
                    if (parseResult)
                    {
                     Console.WriteLine("Dodawanie zakończone sukcesem.");
                    }
                    else
                    {
                        Console.WriteLine("Porażka");
                    }

                    if (command.ToUpper().Trim() == "ShowAll")
                    {
                        Console.WriteLine($"{"Zadanie".PadLeft(10)}||{"Data dodania".PadLeft(10)}");
                    }
                }
            }
            while (command == "exit");
            
        }
    }
}
