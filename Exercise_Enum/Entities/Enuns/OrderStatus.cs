using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Enum.Entities.Enuns
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
