using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExtensionMethods
{
    internal class Order
    {
        public int Id { get; set; }
        public int Pirce { get; set; }
        public static int operator + (Order left, Order right)
        {
            return left.Pirce + right.Pirce;
        }

        public static implicit operator int(Order order)
        {
            return order.Pirce;
        }

    }
}
