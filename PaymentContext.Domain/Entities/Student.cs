using System.Linq;
using System;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscription;
        public Student (Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();

            AddNotifications(Name, Document, Email);            
        }
    
        public Name Name { get; private set; }
        public Document Document { get; private set; }   
        public Email Email { get; private set; }   
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscription.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            foreach (Subscription sub in Subscriptions)
                sub.Deactivate();

            _subscription.Add(subscription);
        }
    }
}