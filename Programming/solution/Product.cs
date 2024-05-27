using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[DataContract]
public class Product
{
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Manufacturer { get; set; }
    [DataMember]
    public ProductCategory Category { get; set; }
    [DataMember]
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
