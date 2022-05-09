using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; private set; }
        public decimal? PurchasePrice { get; set; } // ? nullable or decimal
        public int Quantity { get; set; }


        ///<summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            //Code that retrieves the order item

            return new OrderItem();
        }


        /// <summary>
        /// Saves current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the order item

            return true;
        }

        /// <summary>
        /// Validates the order item
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
