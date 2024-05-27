
public class Product
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public ProductCategory Category { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

public enum ProductCategory
{
    Electronics,
    Clothing,
    Food,
    Books,
    Other
}
