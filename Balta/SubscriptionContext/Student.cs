using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscription = new List<Subscription>();
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscription { get; set; }
        
        public void CreatSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já possui assinatura ativa"));
                return;
            }

            Subscription.Add(subscription);
        }

        public bool IsPremium => Subscription.Any(x => !x.IsInactive);
    }
}