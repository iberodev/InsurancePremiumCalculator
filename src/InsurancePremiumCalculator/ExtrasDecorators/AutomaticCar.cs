namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class AutomaticCar : PremiumDecorator
    {
        private readonly Policy _policy;

        public AutomaticCar(Policy policy)
        {
            _policy = policy;
        }

        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, Automatic car";
        }

        public override double GetCost()
        {
            return 1 + _policy.GetCost();
        }
    }
}
