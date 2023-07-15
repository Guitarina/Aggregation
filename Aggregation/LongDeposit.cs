namespace Aggregation
{

    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal depositAmount, int depositPeriod):base(depositAmount, depositPeriod)
        {

        }

        public override decimal Income()
        {
            decimal currentSum = Amount;

            for (int i = 6; i < Period; i++)
            {
                currentSum = currentSum * 1.15M;
            }
            return currentSum - Amount;
        }
    }
}