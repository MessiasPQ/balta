using System;
using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium ", "O aluno já tem assinatura ativa"));
                return;
            }

            Subscription.Add(subscription);
        }

        private void AddNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}