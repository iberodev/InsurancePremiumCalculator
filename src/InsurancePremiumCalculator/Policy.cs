using InsurancePremiumCalculator.Policies;

namespace InsurancePremiumCalculator
{
    public abstract class Policy
    {
        public virtual string GetDescription() {
            return "Unknown Premium";
        }
        public abstract double GetCost();

        public LicenseType DrivingLicense { get; set; } = LicenseType.National;
    }
}
