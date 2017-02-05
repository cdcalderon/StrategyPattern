using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_After.BSL;

namespace Strategy_After.Test
{
    public class Factory
    {
        public static Customer Create_Customer_With_StudentDiscount()
        {
            return new Customer()
            {
                DiscountMethod = Customer.DiscountOptions.StudentDiscount,
                Name = "Carlos",
                CustomerId = 1234
            };
        }

        public static Customer Create_Customer_With_LoyalDiscount()
        {
            return new Customer()
            {
                DiscountMethod = Customer.DiscountOptions.LoyalDiscount,
                Name = "Carlos",
                CustomerId = 1234
            };
        }

        public static Customer Create_Customer_With_StudentLoyalDiscount()
        {
            return new Customer()
            {
                DiscountMethod = Customer.DiscountOptions.StudentLoyalDiscount,
                Name = "Carlos",
                CustomerId = 1234
            };
        }
    }
}
