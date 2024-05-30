using System;

namespace WarehouseManagement
{
	public class Warehouse
	{
		public string ProductName { get; private set; }
		public string Unit { get; private set; }
		public Money UnitPrice { get; private set; }
		public int Quantity { get; private set; }
		public DateTime LastRestockDate { get; private set; }

		public Warehouse(string productName, string unit, Money unitPrice, int quantity, DateTime lastRestockDate)
		{
			ProductName = productName;
			Unit = unit;
			UnitPrice = unitPrice;
			Quantity = quantity;
			LastRestockDate = lastRestockDate;
		}

		public void Restock(int quantity, DateTime restockDate)
		{
			Quantity += quantity;
			LastRestockDate = restockDate;
		}

		public void Ship(int quantity)
		{
			if (quantity > Quantity)
				throw new ArgumentException("Cannot ship more than available quantity.");

			Quantity -= quantity;
		}
	}
}
