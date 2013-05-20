using System.Collections.Generic;
using DesignPatternsLibrary.CSharpDesignPatternsATutorial.Visitor;
using NUnit.Framework;

namespace DesignPatternsLibrary.Tests.CSharpDesignPatternsATutorial.Visitor
{
    [TestFixture]
    public class VacationVisitorTest
    {
        [Test]
        public void AccumulateTotalVacationDays()
        {
            var es = new List<Employee>
            {
                new Employee(-1, 10, null, -1),
                new Employee(-1, 20, null, -1),
                new Employee(-1, 30, null, -1),
                new Boss(-1, 10, null, -1, bonusDays: 5),
                new Boss(-1, 20, null, -1, bonusDays: 6),
                new Boss(-1, 30, null, -1, bonusDays: 7)
            };

            var sut = new VacationAccumulator();

            foreach (var e in es)
                e.ExtendBehavior(sut);

            Assert.That(sut.TotalVacationDays, Is.EqualTo(138), "total vacation days");
        }
    }
}