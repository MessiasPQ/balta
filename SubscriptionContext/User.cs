using System;
using System.Collections.Generic;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Pass { get; set; }
    }
}