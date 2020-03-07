using System;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrder: true);
        }
    }

    class Program 
    {
        var customer = new Customer();
    }
    
}