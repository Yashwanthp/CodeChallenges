using System;

namespace MyATMMachine
{
    public class MyDisplay : IDisplay
    {
        public void DisplayRemainingBalance(int bal)
        {
            //no-op
        }
        public void DisplayError(object sender, DisplayMsgEventArgs e)
        {
            Console.WriteLine("Error: " + e.Msg);
        }
        public void DisplaySucess(object sender, DisplayMsgEventArgs e)
        {
            Console.WriteLine("Success:\n " + e.Msg);
        }
    }
}