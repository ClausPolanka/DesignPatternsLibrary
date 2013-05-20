using DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers;

namespace DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods
{
    public class PaypalPayment : PaymentMethod
    {
        public string GetDescription()
        {
            return "PaypalDescription";
        }

        public void AcceptModificationsBy(PaymentDataModifier dataModifier)
        {
            dataModifier.SaveDataOf(this);
        }
    }
}