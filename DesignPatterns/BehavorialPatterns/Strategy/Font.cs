namespace DesignPatterns.BehavorialPatterns.Strategy;

// Context
public class Font
{
    public List<string> FontNames = new();
    public FontStrategy Strategy { get; private set; }

    public void SetStrategy(FontStrategy strategy)
    {
        Strategy = strategy;
    }

    public void Add(string name)
    {
        FontNames.Add(name);
    }

    public void Apply()
    {
        Strategy.Apply(FontNames);
    }
}
