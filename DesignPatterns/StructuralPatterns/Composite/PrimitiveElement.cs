namespace DesignPatterns.StructuralPatterns.Composite;

// Leaf class
public class PrimitiveElement : DrawingElement
{
    public PrimitiveElement(string name)
        : base(name)
    { }

    public override void Add(DrawingElement drawingElement)
    {
        throw new ArgumentException("Cannot add to a PrimitiveElement");
    }

    public override void Remove(DrawingElement drawingElement)
    {
        throw new ArgumentException("Cannot remove from a PrimitiveElement");
    }
}
