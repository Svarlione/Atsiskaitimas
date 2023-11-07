namespace Atsiskaitimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resturant restaurant = new Resturant();
            CreatMenue.LoadData();
            Order order = null;
            while (true)
            {
                Console.WriteLine("Pasirinkite norima punkta:");
                Console.WriteLine("1. Staliuku statusas");
                Console.WriteLine("2. Pakeisti statusa");
                Console.WriteLine("3. Pasirinkti staiuka");
                Console.WriteLine("4. Meniu");
                Console.WriteLine("5. Cekas");
                Console.WriteLine("6. Isejimas is sistemos");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        restaurant.TableCountStatus();
                        break;
                    case "2":
                        restaurant.ChangeStatus();
                        break;
                    case "3":
                        Console.WriteLine("Pasirinkit staliuka:");
                        if (int.TryParse(Console.ReadLine(), out int tableNumber))
                        {
                            Table selectedTable = restaurant.GetTableByNumber(tableNumber);
                            if (selectedTable != null)
                            {
                                order = new Order(selectedTable);
                                Console.WriteLine("Aciu uz pasirinkima, staliuko muneris bus pridietas prie uzsakymo.");
                            }
                            else
                            {
                                Console.WriteLine("Atsiprasome, bet tokio staliuko nera.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error 404 :(.....");
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Meniu");
                        foreach (var menuItem in CreatMenue.menueRestoran)
                        {
                            Console.WriteLine($"{menuItem.NumebrLine}. {menuItem.Food}, {menuItem.Price} eur");
                        }

                        Console.WriteLine("Prasome pasirinkti patekalus ir gerimus, jei norite uzbaigti pasirinkima irasykite *q*:");
                        MenueChoice menuChoice = new MenueChoice(order);
                        bool continueChoosing = true;

                        while (continueChoosing)
                        {
                            string input = Console.ReadLine();
                            if (input.ToLower() == "q")
                            {
                                continueChoosing = false;
                            }
                            else if (int.TryParse(input, out int selectedNumber))
                            {
                                menuChoice.Collection(selectedNumber);
                            }
                            else
                            {
                                Console.WriteLine("Atsiprasome, neteisingai ivedet pasirinkima.");
                            }
                        }
                        break;

                    case "5":
                        if (order != null)
                        {
                            order.PrintCheck();
                        }
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Neteisinga ivestis, prasome pasirinkti viena is punktu.Aciu");
                        break;
                }
            }
        }
    }
}