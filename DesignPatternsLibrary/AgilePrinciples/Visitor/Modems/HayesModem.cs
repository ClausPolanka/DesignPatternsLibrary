namespace DesignPatternsLibrary.AgilePrinciples.Visitor.Modems
{
    internal class HayesModem : Modem
    {
        public string configurationString;

        public void Dial(string pno)
        {
        }

        public void HangUp()
        {
        }

        public void Send(char c)
        {
        }

        public char Receive()
        {
            return '\0';
        }

        public void Accept(ModemVisitor modemVisitor)
        {
            modemVisitor.Visit(this);
        }
    }
}