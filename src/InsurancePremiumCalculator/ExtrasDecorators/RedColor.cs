namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class RedColor : PremiumDecorator
    {
        private readonly Policy _policy;

        public RedColor(Policy policy)
        {
            _policy = policy;
        }

        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, Red car";
        }

        public override double GetCost()
        {
            return 5 + _policy.GetCost();
        }
    }
}
