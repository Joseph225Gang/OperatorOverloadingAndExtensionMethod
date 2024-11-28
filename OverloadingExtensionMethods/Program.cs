// See https://aka.ms/new-console-template for more information
using OverloadingExtensionMethods;

Console.WriteLine("Hello, World!");

Order left = new Order()
{
    Id = 1,
    Pirce = 20
};

Order right = new Order()
{
    Id = 2,
    Pirce = 15
};

Console.WriteLine(left + right);

int price = left;

Console.WriteLine(price);


List<Order> orders = new List<Order>();
orders.Add(left);
orders.Add(right);

foreach (Order order in orders.Match(i => i.Pirce > 18))
{
    Console.WriteLine(order.Pirce);
}
