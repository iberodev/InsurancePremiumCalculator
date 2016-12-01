namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class AdditionalDriver : PremiumDecorator
    {
        Policy _policy;

        public AdditionalDriver(Policy policy)
        {
            _policy = policy;
        }

        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, Additional driver";
        }

        public override double GetCost()
        {
            return 9.99 + _policy.GetCost();
        }
    }
}
