using InsurancePremiumCalculator.ExtrasDecorators;
using InsurancePremiumCalculator.Policies;
using System;

namespace InsurancePremiumCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Policy basic = new Basic();
            Console.WriteLine($"{basic.GetDescription()}, ${basic.GetCost()}");

            Policy plus = new Plus();
            Console.WriteLine($"{plus.GetDescription()}, ${plus.GetCost()}");

            Policy silver = new Silver();
            Console.WriteLine($"{silver.GetDescription()}, ${silver.GetCost()}");

            Policy gold = new Gold();
            Console.WriteLine($"{gold.GetDescription()}, ${gold.GetCost()}");

            Policy policy1 = new Gold();
            policy1 = new AutomaticCar(policy1);
            policy1 = new BigEngine(policy1);
            policy1 = new RedColor(policy1);
            policy1 = new YoungDriver(policy1);
            Console.WriteLine($"{policy1.GetDescription()}, ${policy1.GetCost()}");

            Policy policy2 = new Plus();
            policy2 = new AdditionalDriver(policy2);
            policy2 = new AdditionalDriver(policy2); //second additional driver
            policy2 = new RedColor(policy2);
            policy2 = new ManualCar(policy2);
            Console.WriteLine($"{policy2.GetDescription()}, ${policy2.GetCost()}");

            Console.ReadLine();
        }
    }
}
