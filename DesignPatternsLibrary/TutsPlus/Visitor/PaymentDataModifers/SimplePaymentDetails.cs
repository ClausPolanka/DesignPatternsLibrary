using DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods;

namespace DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers
{
    public class SimplePaymentDetails : PaymentDataModifier
    {
        private string description;

        public void SaveDataOf(PaymentMethod paymentMethod)
        {
            description = paymentMethod.GetDescription();
        }

        public string GetModifiedData()
        {
            return description;
        }
    }
}
