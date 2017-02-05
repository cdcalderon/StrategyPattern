using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BSL
{
    public class DiscountOrderCalculatorService
    {
        public decimal ApplyDiscountMethod(Customer customer, decimal totalSale, Func<Customer, decimal, decimal> discountStrategy)
        {
            return discountStrategy(customer, totalSale);
        }
    }
}
