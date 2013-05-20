namespace DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements
{
        public abstract class IElement
        {
            public abstract void Accept(IVisitor visitor);
        }
}