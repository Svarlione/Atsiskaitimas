using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitimas
{
    internal class Resturant
    {
        private List<Table> tables = new List<Table>();

        public void TableCountStatus()
        {
            for (int i = 1; i <= 10; i++)
            {
                tables.Add(new Table(i));
            }

            foreach (Table table in tables)
            {
                string status;
                if (table.IsOccupied)
                {

                    status = "Uzimtas";
                }
                else
                {

                    status = "Laisvas";
                }
                Console.WriteLine($"Staliukas {table.Number} , {status}");
            }
        }
        public void ChangeStatus()// parasytas su *****GPT***** :(
        {
            Console.WriteLine("Pasirinkit staliuka");
            int selectedTableNumber;
            if (int.TryParse(Console.ReadLine(), out selectedTableNumber) && selectedTableNumber >= 1 && selectedTableNumber <= 10)
            {
                Table selectedTable = tables[selectedTableNumber - 1];
                selectedTable.IsOccupied = !selectedTable.IsOccupied;
                Console.WriteLine($"Staliukas {selectedTable.Number} dabar yra {(selectedTable.IsOccupied ? "uzimtas" : "laisvas")}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Neteisngai pasirinktas staliukas arba tokio pasirinkimo nera.");
            }
        }

        public Table GetTableByNumber(int tableNumber)
        {
            return tables.FirstOrDefault(table => table.Number == tableNumber);
        }
    }
}
