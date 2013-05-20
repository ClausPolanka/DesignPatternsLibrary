namespace DesignPatternsLibrary.CSharpDesignPatternsATutorial.Visitor
{
    public class Employee
    {
        int sickDays, vacDays;
        float salary;
        string name;

        public Employee(int sickDays, int vacDays, string name, float salary)
        {
            this.sickDays = sickDays;
            this.vacDays = vacDays;
            this.name = name;
            this.salary = salary;
        }

        public virtual void ExtendBehavior(IVisitor v) 
        {
            v.Visit(this);
        }

        public int SickDays
        {
            get { return sickDays; }
        }

        public int VacDays
        {
            get { return vacDays; }
        }

        public float Salary
        {
            get { return salary; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
