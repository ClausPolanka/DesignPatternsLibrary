namespace DesignPatternsLibrary.AgilePrinciples.Visitor.Modems
{
    interface Modem
    {
        void Dial(string pno);
        void HangUp();
        void Send(char c);
        char Receive();
        void Accept(ModemVisitor modemVisitor);
    }
}
