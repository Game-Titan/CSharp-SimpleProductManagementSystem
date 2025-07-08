namespace CSharp_SimpleProductManagementSystem
{
    
        internal class Program
        {
            /// <summary>
            /// Main entry point for the Product Management System.
            /// Demonstrates basic product operations.
            /// </summary>
            static void Main(string[] args)
            {
                Product product1 = new Product("1 Gallon Milk", 234, 4.09M, 15);
                Product product2 = new Product(" 1 Pound Bread", 262, 1.91M, 10);

                product1.DisplayProductInfo();
                decimal product1_Price = product1.CalculateTotalPrice();
                Console.WriteLine($"Total Stock Price: ${product1_Price}");

                // Add visual separation for second product's output.
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                product2.DisplayProductInfo();
                decimal product2_Price = product2.CalculateTotalPrice();
                Console.WriteLine($"Total Stock Price: ${product2_Price}");
            }

            /// <summary>
            /// Represents a product with its attributes and management operations.
            /// </summary>
            class Product
            {
                // Product properties.
                string name;
                int ProductId;
                decimal Price;
                int StockQuantity;

                /// <summary>
                /// Initializes a new Product instance.
                /// </summary>
                public Product(string name, int ProductId, decimal Price, int StockQuantity)
                {
                    this.name = name;
                    this.ProductId = ProductId;
                    this.Price = Price;
                    this.StockQuantity = StockQuantity;
                }

                /// <summary>
                /// Displays the product's details to the console.
                /// </summary>
                public void DisplayProductInfo()
                {
                    Console.WriteLine("Product Information:");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Product ID: {ProductId}");
                    Console.WriteLine($"Price: ${Price}");
                    Console.WriteLine($"Stock Quantity: {StockQuantity}");
                }

                /// <summary>
                /// Calculates the total value of all stock for this product.
                /// </summary>
                /// <returns>The total stock value.</returns>
                public decimal CalculateTotalPrice()
                {
                    return Price * StockQuantity;
                }
            }
        }
    
}
