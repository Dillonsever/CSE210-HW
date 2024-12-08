class Product
{
    private string Name;
    private string ProductId;
    private decimal PricePerUnit;
    private int Quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }

    public string GetPackingDetails()
    {
        return $"{Name} (ID: {ProductId})";
    }
}