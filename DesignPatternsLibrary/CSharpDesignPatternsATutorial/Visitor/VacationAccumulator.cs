namespace DesignPatternsLibrary.CSharpDesignPatternsATutorial.Visitor
{
    public class VacationAccumulator : IVisitor
    {
        private int totalVacationDays;

        public override void Visit(Employee employee)
        {
            totalVacationDays += employee.VacDays;
            var boss = employee as Boss;
            
            if (boss != null)
                totalVacationDays += boss.BonusDays;
        }

        public override void Visit(Boss boss)
        {
            Visit((Employee) boss);
        }

        public int TotalVacationDays
        {
            get { return totalVacationDays; }
        }
    }
}