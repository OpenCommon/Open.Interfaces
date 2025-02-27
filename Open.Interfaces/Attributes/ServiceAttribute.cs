namespace Open.Interfaces.Attributes;

public class ServiceAttribute : Attribute
{
    public ServiceAttribute() : this(888)
    {
    }

    public ServiceAttribute(int initializeOrder)
    {
        InitializeOrder = initializeOrder;
    }

    public int InitializeOrder { get; set; }
}