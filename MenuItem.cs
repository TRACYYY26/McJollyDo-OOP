namespace McJollyDo_OOP
{
    public class MenuItem
    {
        public string Name { get; }
        public int Price { get; }

        public MenuItem(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
