namespace Open.Interfaces;

public class OrderAttribute : Attribute
{
    public OrderAttribute()
    {

    }

    public OrderAttribute(int order)
    {
        Order = order;
    }

    public int Order { get; set; }
}