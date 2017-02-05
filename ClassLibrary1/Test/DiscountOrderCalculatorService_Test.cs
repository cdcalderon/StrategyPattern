using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.BSL;
using NUnit.Framework;

namespace ClassLibrary1.Test
{
    public class DiscountOrderCalculatorService_Test
    {
        [Test]
        public void When_Apply_Student_Discount_The_Cost_Is_15_Percent_Lest()
        {
            var discount = 15; //15%
            Func<Customer, decimal, decimal> studentDiscountStrategy = (c, totalSale) => 
                                                                       (decimal)(100 - discount) * totalSale / 100;
            var discountOrderCalculatorService = new DiscountOrderCalculatorService();
            var customer = Factory.Create_Customer_With_StudentDiscount();
            var finalPrice = 
                discountOrderCalculatorService.ApplyDiscountMethod(customer, 100, studentDiscountStrategy);
            Assert.AreEqual(85, finalPrice);
        }

        [Test]
        public void When_Apply_Loyal_Discount_The_Cost_Is_10_Percent_Lest()
        {
            var discount = 10; //10%
            Func<Customer, decimal, decimal> studentDiscountStrategy = (c, totalSale) => 
                                                                       (decimal)(100 - discount) * totalSale / 100;
            var discountOrderCalculatorService = new DiscountOrderCalculatorService();
            var customer = Factory.Create_Customer_With_LoyalDiscount();
            var finalPrice = 
                discountOrderCalculatorService.ApplyDiscountMethod(customer, 100, studentDiscountStrategy);
            Assert.AreEqual(90, finalPrice);
        }

        [Test]
        public void When_Apply_StudentLoyal_Discount_The_Cost_Is_30_Percent_Lest()
        {
            var discount = 30; //30%
            Func<Customer, decimal, decimal> studentDiscountStrategy = (c, totalSale) => 
                                                                       (decimal)(100 - discount) * totalSale / 100;
            var discountOrderCalculatorService = new DiscountOrderCalculatorService();
            var customer = Factory.Create_Customer_With_StudentLoyalDiscount();
            var finalPrice = 
                discountOrderCalculatorService.ApplyDiscountMethod(customer, 100, studentDiscountStrategy);
            Assert.AreEqual(70, finalPrice);
        }
    }
}
