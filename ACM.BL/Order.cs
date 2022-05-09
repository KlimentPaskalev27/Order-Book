using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        // DateTimeOffset tracks date, time and time offset for different locations
        // ? denotes a nullable type - it can either be a date or null
        public int OrderId { get; private set; }


        ///<summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //Code that retrieves the defined order

            return new Order();
        }


        /// <summary>
        /// Saves current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
