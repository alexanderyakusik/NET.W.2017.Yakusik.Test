using System;

namespace Task3.Solution
{
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(int usd, int euro)
        {
            this.USD = usd;
            this.Euro = euro;
        }

        public int USD { get; }
        public int Euro { get; }
    }
}
