using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Enum.Entities
{
    class OrderItem
    {
        // propriedades
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        // construtores
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

    }
}
