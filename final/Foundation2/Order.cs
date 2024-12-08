class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        total += Customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += product.GetPackingDetails() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return Customer.GetShippingDetails();
    }
}