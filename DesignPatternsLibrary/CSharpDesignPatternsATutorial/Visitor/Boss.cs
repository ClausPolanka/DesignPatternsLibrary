namespace DesignPatternsLibrary.CSharpDesignPatternsATutorial.Visitor
{
    public class Boss : Employee
    {
        public Boss(int sickDays, int vacDays, string name, float salary, int bonusDays) 
            : base (sickDays, vacDays, name, salary)
        {
            BonusDays = bonusDays;
        }

        public int BonusDays { get; set; }
    }
}