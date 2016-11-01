using System;

namespace MyATMMachine
{
    public class DisplayMsgEventArgs : EventArgs
    {
        public string Msg { get; set; }
        public DisplayMsgEventArgs(string msg)
        {
            this.Msg = msg;
        }
    }
}