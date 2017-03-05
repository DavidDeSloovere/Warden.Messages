using System;
using Warden.Messages.Events;

namespace Warden.Messages.Events.Features
{
    public class UserPaymentPlanCreated : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid PlanId { get; }
        public string Name { get; }
        public decimal MonthlyPrice { get; }

        protected UserPaymentPlanCreated()
        {
        }

        public UserPaymentPlanCreated(Guid requestId, string userId, 
            Guid planId, string name, decimal monthlyPrice)
        {
            RequestId = requestId;
            UserId = userId;
            PlanId = planId;
            Name = name;
            MonthlyPrice = monthlyPrice;
        }
    }
}