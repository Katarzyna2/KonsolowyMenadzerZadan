using System;
using System.Collections.Generic;

namespace KonsolowyMenadżerZadan
{
    public class Program
    {
        //public static object Resources { get; private set; }
     

       //public static string ToYesNoString(this bool value)
       //     {
       //         return value ? Resources.Yes : Resources.No;
       //     }
       
        public static void Main(string[] args)
        {
            List<TaskModel> taskModels = new List<TaskModel>();
            string command = "";

            do
            {
                Console.WriteLine("Czekam na polecenie:");
                command = Console.ReadLine();
                Console.WriteLine();

                if (command.ToUpper().Trim() == "ADD")
                {
                    Console.Write("Dodaj zadanie: ");
                    string opis = Console.ReadLine();
                    Console.WriteLine();

                    //Console.WriteLine("Czy zadanie jest całodniowe: ");
                    //bool ZadanieCałodniowe = Console.ReadKey(YesNo);
                    //Console.WriteLine();

                    //Console.WriteLine("Czy zadanie jest ważne: ");
                    //bool ZadanieWażne = Console.ReadLine();
                    //Console.WriteLine();

                    Console.Write("Podaj datę rozpoczęcia: ");
                    string datarozpoczecia = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Podaj datę zakończenia: ");
                    string datazakonczenia = Console.ReadLine();
                    Console.WriteLine();

                    TaskModel taskModel = new TaskModel(opis, datarozpoczecia, datazakonczenia);
                    taskModels.Add(taskModel);

                    if (datarozpoczecia == "")
                    {
                        taskModel.DataRozpoczęcia = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                    bool parseResult = DateTime.TryParse(datarozpoczecia, out var d);
                    if (datazakonczenia == "")
                    {
                        taskModel.DataZakonczenia = DateTime.Now.ToString("yyyy-MM-dd");
                    }

                    _ = DateTime.TryParse(datazakonczenia, out var e);

                    if (parseResult)
                    {
                        
                        Console.WriteLine("Dodawanie zakończone sukcesem.");
                    }
                    else
                    {
                        Console.WriteLine("Porażka");
                    }
                }

                    if (command.ToUpper().Trim() == "SHOWALL")
                    {
                        int padding = 20;
                        Console.WriteLine($"{"Opis".PadLeft(padding)}|{"Data rozpoczęcia".PadLeft(padding)}|{"Data zakończenia".PadLeft(padding)}");
                        foreach (var item in taskModels)
                        {
                            string a = "";
                            if(item.Opis != null)
                            {
                                a = item.Opis.PadLeft(padding);
                            }
                            string b = item.Opis?.PadLeft(padding) ?? "Brak";
                            string c = item.Opis != null ? item.Opis.PadLeft(padding) : "Brak";
                            Console.WriteLine($"{item.Opis.PadLeft(padding)}|{item.DataRozpoczęcia.PadLeft(padding)}|{item.DataZakonczenia.PadLeft(padding)}");

                        }
                    }
                
            }
            while (command.ToUpper().Trim() != "EXIT");
            Console.WriteLine("Program Zamknięty");
     
        }

    }
    public class TaskModel
    {
        public string Opis { get; set; }
        public string DataRozpoczęcia { get; set; }
        public string DataZakonczenia { get; set; }
        public bool ZadanieCałodniowe { get; set; }
        public bool ZadanieWażne { get; set; }
        public TaskModel(string opis, string datarozpoczecia, string datazakonczenia)
        {
            Opis = opis;
            DataRozpoczęcia = datarozpoczecia;
            DataZakonczenia = datazakonczenia;
          //  ZadanieCałodniowe = zadanieCałodniowe;
            //ZadanieWażne = zadanieWażne;
        }

       
        public void ShowInfo()
        {
            Console.WriteLine($"{Opis}: Opis: {DataRozpoczęcia}: Data Rozpoczęcia: {DataZakonczenia}: Data Zakończenia:");
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