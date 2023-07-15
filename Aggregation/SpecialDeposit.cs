namespace Aggregation
{

    public class SpecialDeposit:Deposit
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod):base(depositAmount, depositPeriod)
        {

        }

        public override decimal Income()
        {
            decimal currentSum = Amount; 
            for (decimal i = 1; i <= Period; i++)
            {
                currentSum = currentSum + (currentSum * (i / 100M)); 
            }
            return currentSum - Amount;
        }
    }
}