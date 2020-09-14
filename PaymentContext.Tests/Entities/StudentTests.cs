using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdcionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Thiago", "Cunha", "12345678912", "test@hotmail.com");
            student.AddSubscription(subscription);
        }
    }
}
