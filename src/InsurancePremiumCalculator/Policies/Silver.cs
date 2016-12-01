namespace InsurancePremiumCalculator.Policies
{
    public class Silver : Policy
    {
        public Silver()
        {
        }

        public override string GetDescription()
        {
            return "Silver Policy";
        }

        public override double GetCost()
        {
            return 299.99;
        }
    }
}
