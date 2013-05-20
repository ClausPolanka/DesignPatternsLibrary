using DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods;

namespace DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers
{
    public class HtmlPaymentDetails : PaymentDataModifier
    {
        private string description;

        public void SaveDataOf(PaymentMethod paymentMethod)
        {
            description = paymentMethod.GetDescription();
        }

        public string GetModifiedData()
        {
            return "<html><body><div>" + description + "</div></body></hmtl>";
        }
    }
}