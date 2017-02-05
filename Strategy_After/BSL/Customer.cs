namespace Strategy_After.BSL
{
    public class Customer
    {
        public enum DiscountOptions
        {
            NoDiscount = 0,
            StudentDiscount = 15,
            LoyalDiscount = 25,
            StudentLoyalDiscount = 30
        }

        public DiscountOptions DiscountMethod { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }
}
