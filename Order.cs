using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitimas
{
    public class Order : ICheq
    {
        List<CreatMenue> creatMenueList = new();
        Table selectedTable;
        DateTime orderTime;
        double totalAmount;

        public Order(Table table)
        {
            this.selectedTable = table;
            orderTime = DateTime.Now;
        }

        public void Add(CreatMenue creatMenue)
        {
            creatMenueList.Add(creatMenue);
            totalAmount += creatMenue.Price;
        }

        public void PrintCheck()
        {
            Console.Clear();
            Console.WriteLine("Cekis:");
            Console.WriteLine($"Staliuko numeris: {selectedTable.Number}");
            Console.WriteLine("Uzsakytos prekes:");
            foreach (var item in creatMenueList)
            {
                Console.WriteLine($"{item.Food}, {item.Price} eur");
            }
            Console.WriteLine($"Bendra suma: {totalAmount} eur");
            Console.WriteLine($"Data ir laikas: {orderTime}");
        }
    }


}
