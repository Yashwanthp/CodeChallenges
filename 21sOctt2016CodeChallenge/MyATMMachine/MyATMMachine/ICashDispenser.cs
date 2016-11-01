using System;

namespace MyATMMachine
{
    public interface ICashDispenser
    {
        void DispenseCash(long cash);
        bool ValidAmounttoDispence(long cash);
        event EventHandler<DisplayMsgEventArgs> CashDispensedSuccess;
        event EventHandler<DisplayMsgEventArgs> CashDispensedFailed;
    }
}