namespace InsurancePremiumCalculator.Policies
{
    public class Plus : Policy
    {
        public Plus()
        {
        }

        public override string GetDescription()
        {
            return "Plus Policy";
        }

        public override double GetCost()
        {
            return 199.99;
        }
    }
}
