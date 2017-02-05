using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.BSL.DiscountService
{
    public class DiscountOrderCalculatorService
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountOrderCalculatorService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal ApplyDiscountMethod(Customer customer, int totalSale)
        {
            return _discountStrategy.ApplyDiscount(customer, totalSale);
        }
    }
}
