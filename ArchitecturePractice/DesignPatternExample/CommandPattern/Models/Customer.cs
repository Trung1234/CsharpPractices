using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Customer đóng vai trò Client.
    /// </summary>
    public class Customer
    {
        private Waiter waiter;

        public Customer(Waiter waiter)
        {
            this.waiter = waiter;
        }

        /// <summary>
        /// người phục vụ sẽ chỉ quan tâm đến món ăn mà thực khách yêu cầu, 
        /// còn việc chế biến món ăn ấy ra sao 
        /// thì đã có đầu bếp của nhà hàng lo rồi.
        /// </summary>
        /// <param name="request"></param>
        public void Request(string request)
        {
            IOrder order;
            if (request.ToLower().Equals("pizza"))
            {
                order = new Pizza();
            }
            else
            {
                order = new Steak();
            }
            waiter.TakeOrder(order);
        }
    }
}
