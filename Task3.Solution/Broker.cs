using System;

namespace Task3.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            stock.StockChange += Update;
        }

        public void Unregister(Stock stock)
        {
            stock.StockChange -= Update;
        }

        private void Update(object sender, StockChangeEventArgs e)
        {
            if (e.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, e.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, e.USD);
        }
    }
}
