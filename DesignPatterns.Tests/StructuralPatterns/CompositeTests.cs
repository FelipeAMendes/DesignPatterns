using DesignPatterns.StructuralPatterns.Composite;

namespace DesignPatterns.Tests.StructuralPatterns;

public class CompositeTests
{
    [Fact]
    public void CompositeElement_WithThreeChildren_ReturnsChildrenElements()
    {
        var root = new CompositeElement("Picture")
        {
            new PrimitiveElement("Red Line"),
            new PrimitiveElement("Blue Circle")
        };

        Assert.Equal(expected: 2, root.Elements.Count);
    }

    [Fact]
    public void CompositeElement_AddMethodIsCalled_ReturnsChildrenElements()
    {
        var root = new CompositeElement("Picture")
        {
            new PrimitiveElement("Red Line"),
            new PrimitiveElement("Blue Circle"),
            new PrimitiveElement("Green Box")
        };

        const string lastElementName = "Two Circles";
        var compositeElement = new CompositeElement(lastElementName);
        root.Add(compositeElement);

        Assert.Equal(expected: 4, root.Elements.Count);
        Assert.Equal(expected: lastElementName, root.Elements.Last().Name);
    }

    [Fact]
    public void CompositeElement_AddMethodIsCalled_ReturnsGrandChildElements()
    {
        var root = new CompositeElement("Picture")
        {
            new CompositeElement("Two Circles")
            {
                new PrimitiveElement("Black Circle"),
                new PrimitiveElement("White Circle")
            }
        };

        Assert.Equal(expected: 1, root.Elements.Count);
        Assert.Equal(expected: 2, ((CompositeElement)root.Elements.Last()).Elements.Count);
    }

    [Fact]
    public void CompositeElement_RemoveMethodIsCalled_ReturnsChildrenElements()
    {
        const string lastElementName = "Yellow Line";
        var root = new CompositeElement("Picture")
        {
            new PrimitiveElement("Red Line"),
            new CompositeElement("Two Circles"),
            new PrimitiveElement(lastElementName)
        };

        Assert.Equal(expected: 3, root.Elements.Count);
        Assert.True(lastElementName == root.Elements.Last().Name);

        root.Remove(root.Elements.Last());

        Assert.Equal(expected: 2, root.Elements.Count);
        Assert.False(lastElementName == root.Elements.Last().Name);
    }

    [Fact]
    public void LeafPrimitiveElement_AddMethodIsCalled_ThrowsArgumentException()
    {
        var leafPrimitiveElement = new PrimitiveElement("Leaf");

        void Operation() => leafPrimitiveElement.Add(new PrimitiveElement("Child"));

        Assert.Throws<ArgumentException>(Operation);
    }

    [Fact]
    public void LeafPrimitiveElement_RemoveMethodIsCalled_ThrowsArgumentException()
    {
        var leafPrimitiveElement = new PrimitiveElement("Leaf");

        void Operation() => leafPrimitiveElement.Remove(new PrimitiveElement("Child"));

        Assert.Throws<ArgumentException>(Operation);
    }
}
