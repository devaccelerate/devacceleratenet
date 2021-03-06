﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Subscriptions
{
    public class DaSubscriptionAttribute : DaSubscriptionAttribute<int, int?, DaSubscription>
    {
        public DaSubscriptionAttribute()
            : base()
        { }
    }

    public class DaSubscriptionAttribute<TKey, TNullableKey, TSubscription> : DaEntityBase<TKey>, IDaSubscriptionAttribute<TKey>
        where TKey : IEquatable<TKey>
        where TSubscription : IDaSubscription<TKey, TNullableKey>
    {
        public TKey SubscriptionId { get; set; }

        [Required]
        [StringLength(256)]
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime LastUpdatedDateUtc { get; set; }
        public virtual TSubscription Subscription { get; set; }
    }
}
