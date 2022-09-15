namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// Abstract Product
public abstract class PaymentMethod
{
    protected PaymentMethod(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
