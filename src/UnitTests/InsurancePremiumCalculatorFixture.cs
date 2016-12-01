using InsurancePremiumCalculator;
using InsurancePremiumCalculator.ExtrasDecorators;
using InsurancePremiumCalculator.Policies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InsurancePremiumCalculatorFixture
    {
        [TestMethod]
        public void TestBasicPolicy()
        {
            Policy basic = new Basic();
            Assert.AreEqual("Basic Policy $99.99", $"{basic.GetDescription()} ${basic.GetCost()}");
        }

        [TestMethod]
        public void TestManualCarWithInternationalLicense()
        {
            Policy silver = new Silver();
            silver.DrivingLicense = LicenseType.International;
            silver = new ManualCar(silver);
            Assert.AreEqual("Silver Policy, Manual car $340.49", $"{silver.GetDescription()} ${silver.GetCost()}");
        }
    }
}
