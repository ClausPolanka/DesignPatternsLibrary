namespace DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements
{
    public interface IVisitor
    {
        void Visit(Element element);
        void Visit(ElementWithLink elementWithLink);
    }
}