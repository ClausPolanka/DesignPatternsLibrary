namespace DesignPatternsLibrary.AgilePrinciples.Visitor.Modems
{
    internal interface ModemVisitor
    {
        void Visit(HayesModem modem);
        void Visit(ZoomModem modem);
        void Visit(ErnieModem modem);
    }
}