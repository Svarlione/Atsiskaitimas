using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitimas
{
    public class MenueChoice
    {
        private readonly Order order;

        public MenueChoice(Order order)
        {
            this.order = order;
        }

        public void Collection(int selectedNumber)
        {
            // var order = new Order();
            CreatMenue selectedMenu = CreatMenue.menueRestoran.FirstOrDefault(menu => menu.NumebrLine == selectedNumber);
            if (selectedMenu != null)
            {
                Console.WriteLine($"Jus pasirinkot: {selectedMenu.NumebrLine}. {selectedMenu.Food}, {selectedMenu.Price} eur");
                order.Add(selectedMenu);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Neteisingai ivedt arba tokio pasirinkimo nera.");
            }
        }
    }

}

