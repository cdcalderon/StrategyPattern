using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLegacy.BSL
{
    public class DiscountOrderCalculatorService
    {
        public decimal CalculateOrderDiscount(Customer customer, decimal totalSale)
        {
            switch (customer.DiscountMethod)
            {
                case Customer.DiscountOptions.StudentDiscount:
                    return ApplyStudentDiscount(customer, totalSale);

                case Customer.DiscountOptions.LoyalDiscount:
                    return ApplyLoyalDiscount(customer, totalSale);

                case Customer.DiscountOptions.StudentLoyalDiscount:
                    return ApplyStudentLoyalDiscount(customer, totalSale);

                default:
                    throw new UnknownDiscountMethodException("Couldnt find a valid discount Method");

            }

        }

        decimal ApplyStudentDiscount(Customer order, decimal totalSale)
        {
            return (decimal)(100 - 15) * totalSale / 100;
        }

        decimal ApplyLoyalDiscount(Customer order, decimal totalSale)
        {
            return (decimal)(100 - 10) * totalSale / 100;
        }

        decimal ApplyStudentLoyalDiscount(Customer order, decimal totalSale)
        {
            return (decimal)(100 - 30) * totalSale / 100;
        }
    }
}
