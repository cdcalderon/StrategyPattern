using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.BSL.DiscountService
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(Customer customer, decimal totalSale)
        {
            return (decimal)(100 - 15) * totalSale / 100;
        }
    }
}
