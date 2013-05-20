using System;
using DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements;

namespace DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Visitors
{
    public class CountVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Count++;
        }

        public void Visit(ElementWithLink elementWithLink)
        {
            Console.Out.WriteLine("Not counting");
        }

        public void CountElements(Element element)
        {
            element.Accept(this);
            if (element.Link != null) CountElements(element.Link);
            if (element.Next != null) CountElements(element.Next);
        }

        public int Count { get; set; }
    }
}