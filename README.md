# C# Product Management System

This is a simple console-based application implemented in C# to manage product information. It demonstrates basic Object-Oriented Programming (OOP) principles using a `Product` class.

## Features

* **Product Creation:** Define products with a name, ID, price, and stock quantity.
* **Display Information:** Show all details for a specific product.
* **Calculate Total Stock Price:** Compute the total value of stock for a product based on its unit price and available quantity.

## Code Structure

The application primarily consists of a `Product` class.

### `Product` Class

* **Properties:** `name` (string), `ProductId` (int), `Price` (decimal), `StockQuantity` (int).
* **Constructor:** Initializes `Product` objects with all necessary details.
* **Methods:**
    * `DisplayProductInfo()`: Prints all details of the product to the console.
    * `CalculateTotalPrice()`: Returns the total value of the product's stock (`Price * StockQuantity`).

## Future Enhancements (Ideas)

* Add a list or collection to manage multiple products.
* Implement functionalities for adding, removing, or updating products.
* Add user input for creating new products or interacting with the system.
* Implement error handling for invalid inputs.
* Separate classes into different files for better organization.

## Contributing

Feel free to suggest improvements or enhancements by opening issues or submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

