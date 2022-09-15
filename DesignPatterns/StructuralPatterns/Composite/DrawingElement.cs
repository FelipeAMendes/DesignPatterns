namespace DesignPatterns.StructuralPatterns.Composite;

// Component Treenode
public abstract class DrawingElement
{
    public string Name { get; }

    protected DrawingElement(string name)
    {
        Name = name;
    }

    public abstract void Add(DrawingElement drawingElement);
    public abstract void Remove(DrawingElement drawingElement);
}
