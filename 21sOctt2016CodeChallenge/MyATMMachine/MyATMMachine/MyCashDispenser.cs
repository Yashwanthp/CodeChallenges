using System;

namespace MyATMMachine
{
    public class MyCashDispenser : ICashDispenser
    {
        public event EventHandler<DisplayMsgEventArgs> CashDispensedSuccess;
        public event EventHandler<DisplayMsgEventArgs> CashDispensedFailed;

        // TODO: this method should take cash as parameter.
        public void DispenseCash(long cash)
        {
            if (ValidAmounttoDispence(cash))
            {
                ICurrency c = new MyCash(cash);
                c.CalculateDenominations();
                string msg = c.DenominationsDescription();
                OnCashDispensedSucess(msg);
            }
            else {
                OnCashDispensedFailed("Amount cannot be dispensed");
            }
        }

        protected virtual void OnCashDispensedSucess(string msg)
        {
            if (CashDispensedSuccess != null)
            {
                CashDispensedSuccess(this, new DisplayMsgEventArgs(msg));
            }
        }

        protected virtual void OnCashDispensedFailed(string msg)
        {
            if (CashDispensedFailed != null)
            {
                CashDispensedFailed(this, new DisplayMsgEventArgs(msg));
            }
        }

        public bool ValidAmounttoDispence(long cash) => (cash % 100 == 0);

    }
}