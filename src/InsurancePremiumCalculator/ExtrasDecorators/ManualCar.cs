using InsurancePremiumCalculator.Policies;

namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class ManualCar : PremiumDecorator
    {
        private readonly Policy _policy;

        public ManualCar(Policy policy)
        {
            _policy = policy;
        }

        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, Manual car";
        }

        public override double GetCost()
        {
            if(LicenseType.National == _policy.DrivingLicense)
            {
                return 2 + _policy.GetCost();
            }
            return 40.50 + _policy.GetCost();
        }
    }
}
