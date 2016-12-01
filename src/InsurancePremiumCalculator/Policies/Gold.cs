namespace InsurancePremiumCalculator.Policies
{
    public class Gold : Policy
    {
        public Gold()
        {
        }

        public override string GetDescription()
        {
            return "Gold Policy";
        }

        public override double GetCost()
        {
            return 399.99;
        }
    }
}
