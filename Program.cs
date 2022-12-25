using System;
using static System.Console;

namespace BaggageFee
{
    static class Program
    {
        // Check in

        // weigh baggage
        // calculate excess
        // allowance 12 kg
        // calculate fee
        // feePerKilo 5 $

        static void Main(string[] args)
        {
            //int weight = CheckBaggage();
            //int excessWeight = GetExcessWeight(weight);
            //int feeToPay = ComputeAdditionalFee(excessWeight);

            //int additionalFee2 = ComputeAdditionalFee(GetExcessWeight(CheckBaggage()));

            int feeToPay = CheckBaggage()
                .GetExcessWeight()
                .ComputeAdditionalFee();

            WriteLine("More text");
            WriteLine($"You have to pay {feeToPay}$ in baggage fee");
            ReadKey();

        }

        public static int CheckBaggage()
        {
            int registeredWeight = 0;
            bool validInput = false;
            while (validInput == false)
            {
                WriteLine("Register your baggage (in kg)");
                validInput = int.TryParse(ReadLine(), out registeredWeight);
            }
            return registeredWeight;
        }

        public static int GetExcessWeight(this int registeredWeight)
        {
            int excessWeight = 0;
            int allowedWeight = 12;
            if (registeredWeight > allowedWeight)
            {
                excessWeight = registeredWeight - allowedWeight;
            }
            return excessWeight;
        }

        public static int ComputeAdditionalFee(this int excessWeight)
        {
            int additionalFee = 36;
            int feePerKilo = 5;
            additionalFee += excessWeight * feePerKilo;
            return additionalFee;
        }
    }
}
