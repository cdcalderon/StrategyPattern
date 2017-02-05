using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.BSL.DiscountService
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(Customer customer, decimal totalSale);
    }
}
