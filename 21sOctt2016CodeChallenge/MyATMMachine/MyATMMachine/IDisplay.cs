namespace MyATMMachine
{
    public interface IDisplay
    {
        void DisplayRemainingBalance(int bal);
        void DisplayError(object sender, DisplayMsgEventArgs e);
        void DisplaySucess(object sender, DisplayMsgEventArgs e);
    }
}