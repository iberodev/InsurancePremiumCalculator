namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class BigEngine : PremiumDecorator
    {
        private readonly Policy _policy;

        public BigEngine(Policy policy)
        {
            _policy = policy;
        }

        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, > 2.000cc";
        }

        public override double GetCost()
        {
            return 70 + _policy.GetCost();
        }
    }
}
