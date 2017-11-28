using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("MTBank", stock);
            var broker = new Broker("Alexander Shlyapik", stock);

            stock.Market();

            broker.Unregister(stock);

            stock.Market();
        }
    }
}
