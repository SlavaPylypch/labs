using System;

namespace WarehouseManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єктів Money
            Money money1 = new Money(100, 50);
            Money money2 = new Money(50, 25);
            Money discount = new Money(10, 0);

            // Виведення суми грошей на екран
            Console.WriteLine($"Money 1: {money1}");
            Console.WriteLine($"Money 2: {money2}");

            // Створення продукту
            ProductWithCategory product = new ProductWithCategory("Laptop", money1, ProductCategory.Electronics);
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category: {product.Category}");

            // Зменшення ціни продукту
            product.ReducePrice(discount);
            Console.WriteLine($"Product after discount: {product.Name}, Price: {product.Price}");

            // Створення складу
            Warehouse warehouse = new Warehouse("Laptop", "pcs", product.Price, 10, DateTime.Now);
            Console.WriteLine($"Warehouse initial state: {warehouse.ProductName}, Quantity: {warehouse.Quantity}, Last Restock Date: {warehouse.LastRestockDate}");

            // Поповнення складу
            warehouse.Restock(5, DateTime.Now);
            Console.WriteLine($"Warehouse after restock: {warehouse.ProductName}, Quantity: {warehouse.Quantity}, Last Restock Date: {warehouse.LastRestockDate}");

            // Відвантаження товару
            warehouse.Ship(3);
            Console.WriteLine($"Warehouse after shipping: {warehouse.ProductName}, Quantity: {warehouse.Quantity}");

            // Створення звітності
            Reporting reporting = new Reporting();
            reporting.RegisterIncomingGoods("Laptop", "pcs", product.Price, 10, DateTime.Now);
            reporting.RegisterIncomingGoods("Laptop", "pcs", product.Price, 5, DateTime.Now);
            reporting.RegisterOutgoingGoods("Laptop", 3);

            // Звіт по інвентаризації
            string inventoryReport = reporting.InventoryReport();
            Console.WriteLine("Inventory Report:");
            Console.WriteLine(inventoryReport);

            // Створення корзини
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(product);
            cart.AddItem(new Product("Smartphone", money2));

            // Виведення корзини
            Console.WriteLine("Shopping Cart:");
            Console.WriteLine(cart.ToString());

            // Загальна вартість корзини
            Money totalPrice = cart.GetTotalPrice();
            Console.WriteLine($"Total Price of Shopping Cart: {totalPrice}");
        }
    }
}
