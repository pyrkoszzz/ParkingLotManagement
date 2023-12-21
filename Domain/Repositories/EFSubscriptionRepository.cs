using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace Domain.Repositories
{
    public class EFSubscriptionRepository : ISubscriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public EFSubscriptionRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool AddSubscription(Subscription subscription)
        {
            _context.Subscriptions.Add(subscription);
            var affectedRows = _context.SaveChanges();
            return affectedRows > 0 ? true : false;
        }

        public bool DeleteSubscription(int SubscriptionId)
        {
            var subscriptionToDelete = _context.Subscriptions.Find(SubscriptionId);

            if (subscriptionToDelete == null)
            {
                throw new Exception("Not found");
            }

            subscriptionToDelete.IsDeleted = true;
            _context.Entry(subscriptionToDelete).State = EntityState.Modified;
            var affectedRows = _context.SaveChanges();
            return affectedRows > 0 ? true : false;
        }

        public IEnumerable<Subscription> GetAllSubscriptions()
        {
            return _context.Subscriptions.ToList();
        }

        public bool UpdateSubscription(Subscription subscription)
        {
            _context.Entry(subscription).State = EntityState.Modified;
            var affectedRows = _context.SaveChanges();
            return affectedRows > 0 ? true : false;
        }
    }
}
