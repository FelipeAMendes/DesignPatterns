namespace DesignPatterns.BehavorialPatterns.Strategy;

// ConcreteStrategy
public class FontSansSerif : FontStrategy
{
    public override void Apply(List<string> items)
    {
        for (var i = 0; i < items.Count; i++)
        {
            items[i] = $"{nameof(FontSansSerif)}: {items[i]}";
        }
    }
}
