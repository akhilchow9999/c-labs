using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    public class Order
    {
        private static int _orderId = 0;
        private DateTime _dateOfOrder;

        public static int OrderId { get => _orderId; set => _orderId = value; }

        public DateTime DateOfOrder { get => _dateOfOrder; set => _dateOfOrder = value; }
    }
}
