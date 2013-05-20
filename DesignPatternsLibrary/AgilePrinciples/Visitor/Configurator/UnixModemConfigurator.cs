using DesignPatternsLibrary.AgilePrinciples.Visitor.Modems;

namespace DesignPatternsLibrary.AgilePrinciples.Visitor.Configurator
{
    class UnixModemConfigurator : ModemVisitor
    {
        public void Visit(HayesModem modem)
        {
            modem.configurationString = "&s1=4&D=3";
        }

        public void Visit(ZoomModem modem)
        {
            modem.configurationValue = 42;
        }

        public void Visit(ErnieModem modem)
        {
            modem.internalPattern = "c is too slow";
        }
    }
}