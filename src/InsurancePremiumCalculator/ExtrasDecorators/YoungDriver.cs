namespace InsurancePremiumCalculator.ExtrasDecorators
{
    public class YoungDriver : PremiumDecorator
    {
        Policy _policy;

        public YoungDriver(Policy policy)
        {
            _policy = policy;
        }
       
        public override string GetDescription()
        {
            return $"{_policy.GetDescription()}, < 25 years old"; 
        }

        public override double GetCost()
        {
            return 20 + _policy.GetCost();
        }
    }
}
