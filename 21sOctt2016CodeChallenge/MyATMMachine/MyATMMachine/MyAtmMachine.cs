namespace MyATMMachine
{
    public class MyAtmMachine : IAtmMachine
    {
        public ICashDispenser _cashDispenser;
        public IDisplay _display;
        long _withdrawAmount;

        // TODO: Take dispenser and display as constructor parameters
        public MyAtmMachine(ICashDispenser cd, IDisplay dis, long withdrawAmount)
        {
            _cashDispenser = cd;
            _display = dis;
            _withdrawAmount = withdrawAmount;
        }

        public void WithdrawCash(long cash)
        {
            _cashDispenser.CashDispensedSuccess += _display.DisplaySucess;
            _cashDispenser.CashDispensedFailed += _display.DisplayError;
            _cashDispenser.DispenseCash(_withdrawAmount);
        }
    }
}