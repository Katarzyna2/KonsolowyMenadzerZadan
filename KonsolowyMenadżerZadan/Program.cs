using System;
using System.Collections.Generic;

namespace KonsolowyMenadżerZadan
{
    class Program
    {
        //public static object Resources { get; private set; }
    

        public class TaskModel
        {
            public TaskModel(string opis, string datarozpoczecia, string datazakonczenia, bool zadanieCałodniowe, bool zadanieWażne)
            {
                Opis = opis;
                DataRozpoczęcia = datarozpoczecia;
                DataZakonczenia = datazakonczenia;
                ZadanieCałodniowe = zadanieCałodniowe;
                ZadanieWażne = zadanieWażne;
            }
            
            public string Opis { get; set; }
            public string DataRozpoczęcia { get; set; }
            public string DataZakonczenia { get; set; }
            public bool ZadanieCałodniowe { get; set; }
            public bool ZadanieWażne { get; set; }
        }

       //public static string ToYesNoString(this bool value)
       //     {
       //         return value ? Resources.Yes : Resources.No;
       //     }
       
        static void Main(string[] args)
        {
            List<TaskModel> zadania = new List<TaskModel>();
            string command = "";

            do
            {
                Console.WriteLine("Czekam na polecenie:");
                command = Console.ReadLine();
                Console.WriteLine();

                if (command.ToUpper().Trim() == "ADD")
                {
                    Console.Write("Dodaj zadanie: ");
                    string Opis = Console.ReadLine();
                    Console.WriteLine();

                    //Console.WriteLine("Czy zadanie jest całodniowe: ");
                    //bool ZadanieCałodniowe = Console.ReadKey(YesNo);
                    //Console.WriteLine();

                    //Console.WriteLine("Czy zadanie jest ważne: ");
                    //bool ZadanieWażne = Console.ReadLine();
                    //Console.WriteLine();

                    Console.Write("Podaj datę rozpoczęcia: ");
                    string DataRozpoczecia = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Podaj datę zakończenia: ");
                    string DataZakonczenia = Console.ReadLine();
                    Console.WriteLine();

                    bool parseResult = DateTime.TryParse(DataZakonczenia, out var d);
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
            while (command != "exit");
            Console.WriteLine("Program Zamknięty");

        }

        private static ConsoleKeyInfo GetZadanieCałodniowe()
        {
            return Console.ReadKey();
        }
    }
}

/*public static class ConsoleEx
    {
        public static List<ConsoleHistory> OutputMessages = new List<ConsoleHistory>();
        public static void WriteLine(string message, ConsoleColor consoleColor = ConsoleColor.Green) // green jest domyślnym kolorem, trzeba definiować
        {
            DateTime date = DateTime.Now;
            OutputMessages.Add(new ConsoleHistory()
            {
                Date = date,
                Messsage = message
            });

            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor; // zwraca kolor napisów w konsoli
            Console.WriteLine($"{date.ToString("yyyy-MM-dd HH-mm-ss")} {message}");
        }
    }
*/