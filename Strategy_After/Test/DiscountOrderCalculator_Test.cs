using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Strategy_After.BSL.DiscountService;

namespace Strategy_After.Test
{
    public class DiscountOrderCalculator_Test
    {
        [Test]
        public void When_Apply_Student_Discount_The_Cost_Is_15_Percent_Lest()
        {
            var strategy = new StudentDiscountStrategy();
            var discountOrderCalculatorService = new DiscountOrderCalculatorService(strategy);
            var customer = Factory.Create_Customer_With_StudentDiscount();
            var finalPrice = discountOrderCalculatorService.ApplyDiscountMethod(customer, 100);
            Assert.AreEqual(85, finalPrice);
        }

        [Test]
        public void When_Apply_Loyal_Discount_The_Cost_Is_10_Percent_Lest()
        {
            var strategy = new LoyalDiscountStrategy();
            var discountOrderCalculatorService = new DiscountOrderCalculatorService(strategy);
            var customer = Factory.Create_Customer_With_LoyalDiscount();
            var finalPrice = discountOrderCalculatorService.ApplyDiscountMethod(customer, 100);
            Assert.AreEqual(90, finalPrice);
        }

        [Test]
        public void When_Apply_StudentLoyal_Discount_The_Cost_Is_30_Percent_Lest()
        {
            var strategy = new LoyalStudentDiscountStrategy();
            var discountOrderCalculatorService = new DiscountOrderCalculatorService(strategy);
            var customer = Factory.Create_Customer_With_StudentLoyalDiscount();
            var finalPrice = discountOrderCalculatorService.ApplyDiscountMethod(customer, 100);
            Assert.AreEqual(70, finalPrice);
        }
    }
}
