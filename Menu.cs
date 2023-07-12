using System;
using System.Collections.Generic;

namespace McJollyDo_OOP
{
    public class Menu
    {
        private Dictionary<int, MenuItem> menuItems;

        public Menu()
        {
            menuItems = new Dictionary<int, MenuItem>
            {
                { 1, new MenuItem("McJollyDo Burger Yumdo   ", 120) },
                { 2, new MenuItem("McJollyDo Spaghetti      ", 100) },
                { 3, new MenuItem("McJollyDo McChickenJoy   ", 135) },
                { 4, new MenuItem("McJollyDo Apple Mango Pie", 55) }
            };
        }

        public void DisplayMenu()
        {
            Console.WriteLine("                  McJollyDo Menu");
            Console.WriteLine("_______________________________________________________");

            foreach (var item in menuItems)
            {
                Console.WriteLine($"Select {item.Key} to order {item.Value.Name} | {item.Value.Price} Php");
            }

            Console.WriteLine("Select 5 to cancel order attempt");
            Console.WriteLine("_______________________________________________________");
        }

        public void ProcessOrders(Order order)
        {
            bool continueOrdering = true;

            while (continueOrdering)
            {
                Console.Write("Enter Order: ");
                int orderNum = Convert.ToInt32(Console.ReadLine());

                if (menuItems.TryGetValue(orderNum, out var menuItem))
                {
                    Console.WriteLine($"The order you selected is: {menuItem.Name}");
                    Console.WriteLine($"Cost: {menuItem.Price} Php");
                    Console.WriteLine();
                    Console.WriteLine("Press 9 to confirm order");
                    Console.WriteLine("Press 8 to add order");
                    Console.WriteLine("Press 0 to cancel order");

                    Console.Write("Press: ");
                    int processAction = Convert.ToInt32(Console.ReadLine());

                    if (processAction == 9 || processAction == 8)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Order Confirmed");
                        order.AddOrder(menuItem);
                    }
                    else if (processAction == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Order Cancelled");
                    }
                    else
                    {
                        Console.WriteLine("Invalid action. Order cancelled");
                    }
                }
                else if (orderNum == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have cancelled your order attempt");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid order selection. Please try again.");
                    continue;
                }

                Console.WriteLine("");
                Console.WriteLine("Do you want to place another order? (YES or NO)");
                Console.Write("You have selected: ");
                string continueInput = Console.ReadLine();
                if (!continueInput.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    continueOrdering = false;
                }
            }
        }
    }
}
