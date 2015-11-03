﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusterService
{
    internal class ArmClusterOperatorSettings
    {
        public ArmClusterOperatorSettings(
            string region,
            string clientId,
            string clientSecret,
            string authority,
            string subscriptionId,
            string username,
            string password)
        {
            this.Region = region;
            this.ClientID = clientId;
            this.ClientSecret = clientSecret;
            this.Authority = authority;
            this.SubscriptionID = subscriptionId;
            this.Username = username;
            this.Password = password;
        }

        public string Region { get; private set; }

        public string ClientID { get; private set; }

        public string ClientSecret { get; private set; }

        public string Authority { get; private set; }

        public string SubscriptionID { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }
    }
}