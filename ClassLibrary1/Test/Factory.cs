using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.BSL;

namespace ClassLibrary1.Test
{
    public class Factory
    {
        public static Customer Create_Customer_With_StudentDiscount()
        {
            return new Customer()
            {
                Name = "Carlos",
                CustomerId = 1234
            };
        }

        public static Customer Create_Customer_With_LoyalDiscount()
        {
            return new Customer()
            {
                Name = "Carlos",
                CustomerId = 1234
            };
        }

        public static Customer Create_Customer_With_StudentLoyalDiscount()
        {
            return new Customer()
            {
                Name = "Carlos",
                CustomerId = 1234
            };
        }
    }
}
