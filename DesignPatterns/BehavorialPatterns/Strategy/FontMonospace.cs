namespace DesignPatterns.BehavorialPatterns.Strategy;

// Strategy abstract class
public class FontMonospace : FontStrategy
{
    public override void Apply(List<string> items)
    {
        for (var i = 0; i < items.Count; i++)
        {
            items[i] = $"{nameof(FontMonospace)}: {items[i]}";
        }
    }
}
