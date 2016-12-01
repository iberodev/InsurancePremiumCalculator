namespace InsurancePremiumCalculator.Policies
{
    public class Basic : Policy
    {
        public Basic()
        {
        }

        public override string GetDescription()
        {
            return "Basic Policy";
        }

        public override double GetCost()
        {
            return 99.99;
        }
    }
}
