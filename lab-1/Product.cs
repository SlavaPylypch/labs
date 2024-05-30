using System;

namespace WarehouseManagement
{
    public class Product
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(Money amount)
        {
            if (amount.WholePart > Price.WholePart || (amount.WholePart == Price.WholePart && amount.FractionalPart > Price.FractionalPart))
                throw new ArgumentException("Reduction amount cannot be greater than the current price.");

            int newWholePart = Price.WholePart - amount.WholePart;
            int newFractionalPart = Price.FractionalPart - amount.FractionalPart;

            if (newFractionalPart < 0)
            {
                newWholePart--;
                newFractionalPart += 100;
            }

            Price.SetValue(newWholePart, newFractionalPart);
        }
    }

    public enum ProductCategory
    {
        Food,
        Electronics,
        Clothing,
        Other
    }

    public class ProductWithCategory : Product
    {
        public ProductCategory Category { get; private set; }

        public ProductWithCategory(string name, Money price, ProductCategory category)
            : base(name, price)
        {
            Category = category;
        }
    }
}
