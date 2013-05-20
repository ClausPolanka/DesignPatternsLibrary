using DesignPatternsLibrary.TutsPlus.Visitor.PaymentDataModifers;
using DesignPatternsLibrary.TutsPlus.Visitor.PaymentMethods;
using NUnit.Framework;

namespace DesignPatternsLibrary.Tests.TutsPlus.Visitor
{
    [TestFixture]
    public class PaymentMethodTests
    {
        [Test]
        public void VisaPaymentAcceptsHtmlPaymentDetails()
        {
            var sut = new VisaPayment();
            var informationModifier = new HtmlPaymentDetails();
            
            sut.AcceptModificationsBy(informationModifier);

            Assert.That(
                informationModifier.GetModifiedData, 
                Is.EqualTo("<html><body><div>VisaDescription</div></body></hmtl>"),
                "description");
        }

        [Test]
        public void VisaPaymentAcceptsSimplePaymentDetails()
        {
            var sut = new VisaPayment();
            var informationModifier = new SimplePaymentDetails();
            
            sut.AcceptModificationsBy(informationModifier);

            Assert.That(
                informationModifier.GetModifiedData,
                Is.EqualTo("VisaDescription"),
                "description");
        }

        [Test]
        public void PaypalPaymentAcceptsSimplePaymentDetails()
        {
            var sut = new PaypalPayment();
            var informationModifier = new SimplePaymentDetails();
            
            sut.AcceptModificationsBy(informationModifier);

            Assert.That(
                informationModifier.GetModifiedData,
                Is.EqualTo("PaypalDescription"),
                "description");
        }
    }
}
