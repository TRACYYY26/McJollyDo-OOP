using System;
using System.Collections.Generic;

namespace McJollyDo_OOP
{
    public class Order
    {
        private List<MenuItem> orderedMeals;
        private int totalPrice;

        public Order()
        {
            orderedMeals = new List<MenuItem>();
            totalPrice = 0;
        }

        public void AddOrder(MenuItem menuItem)
        {
            orderedMeals.Add(menuItem);
            totalPrice += menuItem.Price;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("");
            Console.WriteLine("------------- RECEIPT " + PrintReceiptNumber() + " -----------------");
            Console.WriteLine("");

            foreach (var item in orderedMeals)
            {
                Console.WriteLine($"{item.Name} | {item.Price} Php");
            }

            Console.WriteLine("");
            Console.WriteLine($"Total Cost: {totalPrice} Php");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("THANK YOU FOR DINING AT McJollyDo");
            Console.WriteLine("");

            Console.WriteLine("Do you want to save your order to quick orders?");
            Console.WriteLine("Select 1 to accept");
            Console.WriteLine("Select 2 to decline");
            Console.Write("You have selected: ");
            int saveQuickOrders = Convert.ToInt32(Console.ReadLine());
            if (saveQuickOrders == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Order Saved");
                Console.WriteLine("");
                Console.WriteLine("List of Saved Order");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");

                foreach (var item in orderedMeals)
                {
                    Console.WriteLine($"{item.Name} | {item.Price} Php");
                }

                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
            }
            else if (saveQuickOrders == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("THANK YOU FOR DINING AT McJollyDo");
            }
        }

        private int PrintReceiptNumber()
        {
            Random receiptNumGen = new Random();
            int number = receiptNumGen.Next(0, 99);
            return number;
        }
    }
}
