using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

var orders = new List<Order>()
{
    new Order{OrderId=1,CustomerName="John",TotalAmount=500},
    new Order{OrderId=2,CustomerName="Sam",TotalAmount=1500}
};

var result =
    orders
    .Where(o => o.TotalAmount > 1000)
    .Select(o => new
    {
        o.OrderId,
        o.CustomerName
    });

foreach(var r in result)
    Console.WriteLine($"{r.OrderId} {r.CustomerName}");