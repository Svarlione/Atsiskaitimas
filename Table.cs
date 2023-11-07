using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitimas
{
    public class Table
    {
        public int Number { get; }
        public bool IsOccupied { get; set; }

        public Table(int number)
        {
            Number = number;
            IsOccupied = false;
        }

        //private List<CreatTables> tables = new List<CreatTables>();

        //public void TableCountStatus()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        tables.Add(new CreatTables(i));
        //    }

        //    foreach (CreatTables table in tables)
        //    {
        //        string status;
        //        if (table.IsOccupied)
        //        {
        //            Console.ForegroundColor = ConsoleColor.DarkRed;
        //            status = "Uzimtas";
        //        }
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Green;
        //            status = "Laisvas";
        //        }
        //        Console.WriteLine($"Staliukas {table.Number} , {status}");
        //    }
        //}

        //public void ChangeStatus()//sita kodo dali pasidariau su GPT
        //{
        //    Console.WriteLine("Pasirinkit staliuka");
        //    int selectedTableNumber;
        //    if (int.TryParse(Console.ReadLine(), out selectedTableNumber) && selectedTableNumber >= 1 && selectedTableNumber <= 10)
        //    {
        //        CreatTables selectedTable = tables[selectedTableNumber - 1];
        //        selectedTable.IsOccupied = !selectedTable.IsOccupied;
        //        Console.WriteLine($"Staliukas {selectedTable.Number} dabar yra {(selectedTable.IsOccupied ? "uzimtas" : "laisvas")}");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkRed;
        //        Console.WriteLine("Neteisngai pasirinktas staliukas arba tokio pasirinkimo nera.");
        //    }
        //}

    }
}
