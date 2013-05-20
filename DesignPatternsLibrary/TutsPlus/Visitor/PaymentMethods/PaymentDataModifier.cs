using DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers;

namespace DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods
{
    public interface PaymentDataModifier
    {
        void SaveDataOf(PaymentMethod paymentMethod);
        string GetModifiedData(); 
    }
}
