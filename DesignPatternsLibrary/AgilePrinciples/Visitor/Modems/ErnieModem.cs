namespace DesignPatternsLibrary.AgilePrinciples.Visitor.Modems
{
    class ErnieModem : Modem
    {
        public string internalPattern;

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