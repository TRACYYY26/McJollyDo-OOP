using System;

namespace McJollyDo_OOP
{
    public class OrderProcessor
    {
        private Menu menu;
        private Order order;

        public OrderProcessor()
        {
            menu = new Menu();
            order = new Order();
        }

        public void StartOrdering()
        {
            Console.WriteLine("Welcome to McJollyDo ^ v ^");
            Console.WriteLine("");

            menu.DisplayMenu();
            menu.ProcessOrders(order);

            order.PrintReceipt();
        }
    }
}
