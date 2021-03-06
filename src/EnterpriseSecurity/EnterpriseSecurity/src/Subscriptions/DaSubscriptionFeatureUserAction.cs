// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright � Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Subscriptions
{
    public class DaSubscriptionFeatureUserAction : DaSubscriptionFeatureUserAction<int, DaSubscriptionFeatureUser>
    {
        public DaSubscriptionFeatureUserAction() : base()
        { }
    }

    public class DaSubscriptionFeatureUserAction<TKey, TSubscriptionFeatureUser> : DaEntityBase<TKey>, IDaSubscriptionFeatureUserAction<TKey>
        where TKey : IEquatable<TKey>
        where TSubscriptionFeatureUser : IDaSubscriptionFeatureUser<TKey>
    {
        public TKey SubscriptionFeatureUserId { get; set; }

        [Required]
        [StringLength(100)]
        public string ActionName { get; set; }

        public bool? Allowed { get; set; }

        public virtual TSubscriptionFeatureUser SubscriptionFeatureUser { get; set; }
    }
}
