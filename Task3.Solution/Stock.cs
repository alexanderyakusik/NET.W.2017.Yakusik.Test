using System;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<StockChangeEventArgs> StockChange;

        protected virtual void OnStockChange(object sender, StockChangeEventArgs e)
        {
            var stockChange = StockChange;

            stockChange?.Invoke(sender, e);
        }

        public void Market()
        {
            Random rnd = new Random();
            OnStockChange(this, new StockChangeEventArgs(rnd.Next(20, 40), rnd.Next(30, 50)));
        }
    }
}
