using DesignPatterns.BehavorialPatterns.Strategy;

namespace DesignPatterns.Tests.BehavorialPatterns;

public class StrategyTests
{
    [Fact]
    public void FontSansSerif_ApplyMethodIsCalled_ReturnsStrategyCorrectly()
    {
        var fontRecords = new Font();
        fontRecords.Add("Text 1");
        fontRecords.Add("Text 2");

        fontRecords.SetStrategy(new FontSansSerif());
        fontRecords.Apply();

        Assert.Contains(fontRecords.FontNames, x => x.StartsWith(nameof(FontSansSerif)));
        Assert.IsAssignableFrom<FontSansSerif>(fontRecords.Strategy);
    }

    [Fact]
    public void FontSerif_ApplyMethodIsCalled_ReturnsStrategyCorrectly()
    {
        var fontRecords = new Font();
        fontRecords.Add("Text 1");
        fontRecords.Add("Text 2");

        fontRecords.SetStrategy(new FontSerif());
        fontRecords.Apply();

        Assert.Contains(fontRecords.FontNames, x => x.StartsWith(nameof(FontSerif)));
        Assert.IsAssignableFrom<FontSerif>(fontRecords.Strategy);
    }

    [Fact]
    public void FontCursive_ApplyMethodIsCalled_ReturnsStrategyCorrectly()
    {
        var fontRecords = new Font();
        fontRecords.Add("Text 1");
        fontRecords.Add("Text 2");

        fontRecords.SetStrategy(new FontCursive());
        fontRecords.Apply();

        Assert.Contains(fontRecords.FontNames, x => x.StartsWith(nameof(FontCursive)));
        Assert.IsAssignableFrom<FontCursive>(fontRecords.Strategy);
    }

    [Fact]
    public void FontFantasy_ApplyMethodIsCalled_ReturnsStrategyCorrectly()
    {
        var fontRecords = new Font();
        fontRecords.Add("Text 1");
        fontRecords.Add("Text 2");

        fontRecords.SetStrategy(new FontFantasy());
        fontRecords.Apply();

        Assert.Contains(fontRecords.FontNames, x => x.StartsWith(nameof(FontFantasy)));
        Assert.IsAssignableFrom<FontFantasy>(fontRecords.Strategy);
    }

    [Fact]
    public void FontMonospace_ApplyMethodIsCalled_ReturnsStrategyCorrectly()
    {
        var fontRecords = new Font();
        fontRecords.Add("Text 1");
        fontRecords.Add("Text 2");

        fontRecords.SetStrategy(new FontMonospace());
        fontRecords.Apply();

        Assert.Contains(fontRecords.FontNames, x => x.StartsWith(nameof(FontMonospace)));
        Assert.IsAssignableFrom<FontMonospace>(fontRecords.Strategy);
    }
}
