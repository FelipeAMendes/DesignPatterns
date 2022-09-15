namespace DesignPatterns.BehavorialPatterns.Strategy;

// Strategy abstract class
public class FontCursive : FontStrategy
{
    public override void Apply(List<string> items)
    {
        for (var i = 0; i < items.Count; i++)
        {
            items[i] = $"{nameof(FontCursive)}: {items[i]}";
        }
    }
}
