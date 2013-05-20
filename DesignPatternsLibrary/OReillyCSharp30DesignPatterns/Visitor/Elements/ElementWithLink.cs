namespace DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements
{
    public class ElementWithLink : Element
    {
        public ElementWithLink(Element link, Element next)
        {
            Link = link;
            Next = next;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}