class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetShippingDetails()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }
}
