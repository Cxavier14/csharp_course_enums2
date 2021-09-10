using Exercise_Enum.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Enum.Entities
{
    class Order
    {
        // propriedades
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        // construtores
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }
    }
}
