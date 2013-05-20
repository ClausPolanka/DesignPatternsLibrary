using DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers;

namespace DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods
{
    public class VisaPayment : PaymentMethod
    {
        public string GetDescription()
        {
            return "VisaDescription";
        }

        public void AcceptModificationsBy(PaymentDataModifier dataModifier)
        {
            dataModifier.SaveDataOf(this);
        }
    }
}