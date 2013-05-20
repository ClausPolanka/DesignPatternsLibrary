namespace DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements
{
    public class Element : IElement
    {
        public Element() {}

        public Element(Element next)
        {
            Next = next;
        }

        public Element Next { get; set; }
        public Element Link { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}