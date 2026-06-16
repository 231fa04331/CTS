class Product
{
    public string Name { get; set; }

    private decimal price;

    public decimal Price
    {
        get => price;
        set
        {
            if(value >= 0)
                price = value;
        }
    }
}