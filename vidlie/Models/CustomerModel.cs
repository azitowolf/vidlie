using System;
namespace vidlie.Models
{
    public class Customer
    {
        public Customer()
        { 
        }
        public String Id { get; set; }
        public String name { get; set; }
        public String age { get; set; }
        public Boolean HasSubscription { get; set; }
        public Subscription Subscription { get; set; }
        public Double SubscriptionId { get; set; }
    }
}
