namespace CODE_MONKEY_LEARNING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("1 Gallon Milk", 234, 4.09M, 15);
            Product product2 = new Product(" 1 Pound Bread", 262, 1.91M, 10);
            product1.DisplayProductInfo();
            decimal product1_Price = product1.CalculateTotalPrice();
            Console.WriteLine($"Total Stock Price: ${product1_Price}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            product2.DisplayProductInfo();
            decimal product2_Price = product2.CalculateTotalPrice();
            Console.WriteLine($"Total Stock Price: ${product2_Price}");
        }
        class Product
        {
            string name;
            int ProductId;
            decimal Price;
            int StockQuantity;
            
            public Product(string name, int ProductId , decimal Price , int StockQuantity)
            {
                this.name = name;
                this.ProductId = ProductId;
                this.Price = Price;
                this.StockQuantity = StockQuantity;
            }
            public void DisplayProductInfo()
            {
                Console.WriteLine("Product Information:");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Product ID: {ProductId}");
                Console.WriteLine($"Price: ${Price}");
                Console.WriteLine($"Stock Quantity: {StockQuantity}");
                
            }
            public decimal CalculateTotalPrice()
            {
                return Price* StockQuantity;
                 
            }

        }

    }
}
