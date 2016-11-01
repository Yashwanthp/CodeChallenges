namespace MyATMMachine
{
    public class MyCash : ICurrency
    {
        long ThousandDenominations;
        long FiveHunderdDenominations;
        long HundredDenominations;
        long Amount;

        public MyCash(long amount)
        {
            this.Amount = amount;
        }

        public void CalculateDenominations()
        {
            this.ThousandDenominations = this.Amount / 1000;
            var remainingAmount = this.Amount - this.ThousandDenominations * 1000;
            this.FiveHunderdDenominations = remainingAmount / 500;
            remainingAmount = remainingAmount - this.FiveHunderdDenominations * 500;
            this.HundredDenominations = remainingAmount / 100;
        }

        public string DenominationsDescription()
        {
            return "1000 X " + this.ThousandDenominations + "\n500 X " + this.FiveHunderdDenominations + "\n100 X " + this.HundredDenominations;
        }
    }
}