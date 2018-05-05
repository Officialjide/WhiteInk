using System;

namespace Ink.Core.Domain
{
    public class Subscription
    {
        public int SubscriptionId { get; set; } //guid
        public DateTime PurchaseDate { get; set; }
        public DateTime Expiry { get; set; }
        public int Amount { get; set; }
        public string UserId { get; set; }
        public string PaymentSubscriptionId { get; set; }
        public Guid ApiKey { get; set; }
        public string Type { get; set; }//?
        public string FigureAllowed { get; set; } //?
    }
}
