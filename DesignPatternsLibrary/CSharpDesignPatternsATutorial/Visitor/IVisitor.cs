namespace DesignPatternsLibrary.CSharpDesignPatternsATutorial.Visitor
{
    public abstract class IVisitor
    {
        public abstract void Visit(Employee employee);
        public abstract void Visit(Boss boss);
    }
}
