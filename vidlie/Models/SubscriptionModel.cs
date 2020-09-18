using System;
namespace vidlie.Models
{
    public class Subscription
    {
        public Subscription()
        {
        }
        public String Id { get; set; }
        public String SubscriptionType { get; set; }
        public double Duration { get; set; }
        public double Discount { get; set; }
    }
}
