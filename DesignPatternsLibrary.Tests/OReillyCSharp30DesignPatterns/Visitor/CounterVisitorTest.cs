using DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Elements;
using DesignPatternsLibrary.OReillyCSharp30DesignPatterns.Visitor.Visitors;
using NUnit.Framework;

namespace DesignPatternsLibrary.Tests.OReillyCSharp30DesignPatterns.Visitor
{
    [TestFixture]
    public class CounterVisitorTest
    {
        [Test]
        public void CountNumberOfElementsInObjectStructure()
        {
            var sut = new CountVisitor();
            var objectStructure =
                new Element(
                    new Element(
                        new ElementWithLink(
                            new Element(new Element(new ElementWithLink(new Element(null), new Element(null)))),
                            new Element(new Element(new Element(null))))));

            
            sut.CountElements(objectStructure);
            
            Assert.That(sut.Count, Is.EqualTo(9), "elements");
        }
    }
}
