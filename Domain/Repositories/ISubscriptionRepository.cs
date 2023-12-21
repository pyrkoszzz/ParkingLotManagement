using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> GetAllSubscriptions();
        bool AddSubscription(Subscription subscription);
        bool UpdateSubscription(Subscription subscription);
        bool DeleteSubscription(int SubscriptionId);
    }
}
