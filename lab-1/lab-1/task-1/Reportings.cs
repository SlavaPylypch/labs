using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1
{
    public class Reporting
    {
        private List<Warehouse> warehouses;

        public Reporting()
        {
            warehouses = new List<Warehouse>();
        }

        public void RegisterIncomingGoods(string productName, string unit, Money unitPrice, int quantity, DateTime restockDate)
        {
            var warehouse = warehouses.FirstOrDefault(w => w.ProductName == productName && w.Unit == unit);

            if (warehouse == null)
            {
                warehouse = new Warehouse(productName, unit, unitPrice, quantity, restockDate);
                warehouses.Add(warehouse);
            }
            else
            {
                warehouse.Restock(quantity, restockDate);
            }
        }

        public void RegisterOutgoingGoods(string productName, int quantity)
        {
            var warehouse = warehouses.FirstOrDefault(w => w.ProductName == productName);

            if (warehouse == null)
                throw new ArgumentException("Product not found in warehouse.");

            warehouse.Ship(quantity);
        }

        public string InventoryReport()
        {
            var report = new StringBuilder();
            foreach (var warehouse in warehouses)
            {
                report.AppendLine($"{warehouse.ProductName} - {warehouse.Quantity} {warehouse.Unit} at {warehouse.UnitPrice}");
            }
            return report.ToString();
        }
    }
}
