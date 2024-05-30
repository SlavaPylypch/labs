using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public Money GetTotalPrice()
        {
            int totalWhole = 0;
            int totalFractional = 0;

            foreach (var item in items)
            {
                totalWhole += item.Price.WholePart;
                totalFractional += item.Price.FractionalPart;
            }

            totalWhole += totalFractional / 100;
            totalFractional = totalFractional % 100;

            return new Money(totalWhole, totalFractional);
        }

        public override string ToString()
        {
            var report = new StringBuilder();
            foreach (var item in items)
            {
                report.AppendLine($"{item.Name} - {item.Price}");
            }
            return report.ToString();
        }
    }
}
