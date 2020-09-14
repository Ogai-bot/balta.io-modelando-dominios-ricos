using System.Linq;
using System;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscription;
        public Student (Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();
        }
    
        public Name Name { get; private set; }
        public Document Document { get; private set; }   
        public string Email { get; private set; }   
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscription.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            foreach (Subscription sub in Subscriptions)
                sub.Deactivate();

            _subscription.Add(subscription);
        }
    }
}