using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitimas
{
    public class CreatMenue
    {
        public int NumebrLine { get; init; }
        public string Food { get; init; }
        public double Price { get; init; }

        public CreatMenue(int numberLine, string food, double price)
        {
            NumebrLine = numberLine;
            Food = food;
            Price = price;
        }

        private static string menue = "restarantMenue.txt";
        public static List<CreatMenue> menueRestoran = new List<CreatMenue>();

        public static void LoadData()
        {
            if (File.Exists(menue))
            {
                string[] lines = File.ReadAllLines(menue);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3)
                    {
                        if (int.TryParse(parts[0], out int numberLine))
                        {
                            string food = parts[1];
                            if (double.TryParse(parts[2], out double price))
                            {
                                CreatMenue choice = new CreatMenue(numberLine, food, price);
                                menueRestoran.Add(choice);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Atsiprasau, bet *Menue* failo nerandu");
                Console.ResetColor();
                Console.WriteLine("Paspauskit bet koki klavisa kad iseiti...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}