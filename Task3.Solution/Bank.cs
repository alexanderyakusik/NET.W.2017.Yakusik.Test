using System;

namespace Task3.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            stock.StockChange += Update;
        }

        private void Update(object sender, StockChangeEventArgs e)
        {
            if (e.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, e.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, e.Euro);
        }
    }
}
