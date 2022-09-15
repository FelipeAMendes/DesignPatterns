using System.Collections;

namespace DesignPatterns.StructuralPatterns.Composite;

// Composite class
public class CompositeElement : DrawingElement, IEnumerable<DrawingElement>
{
    private List<DrawingElement> _elements;
    public IReadOnlyCollection<DrawingElement> Elements => _elements?.AsReadOnly();

    public CompositeElement(string name)
        : base(name)
    { }

    public override void Add(DrawingElement drawingElement)
    {
        _elements ??= new List<DrawingElement>();
        _elements.Add(drawingElement);
    }

    public override void Remove(DrawingElement drawingElement)
    {
        _elements ??= new List<DrawingElement>();
        _elements.Remove(drawingElement);
    }

    public IEnumerator<DrawingElement> GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }
}