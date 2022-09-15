namespace DesignPatterns.BehavorialPatterns.Strategy;

// ConcreteStrategy
public class FontSerif : FontStrategy
{
    public override void Apply(List<string> items)
    {
        for (var i = 0; i < items.Count; i++)
        {
            items[i] = $"{nameof(FontSerif)}: {items[i]}";
        }
    }
}
