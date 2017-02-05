using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.BSL.DiscountService
{
    public class LoyalStudentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(Customer customer, decimal totalSale)
        {
            return (decimal)(100 - 30) * totalSale / 100;
        }
    }
}
