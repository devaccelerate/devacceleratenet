// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright � Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core;
using Ejyle.DevAccelerate.EnterpriseSecurity.SubscriptionPlans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Subscriptions
{
    public class DaSubscription : DaSubscription<int, int?, DaSubscriptionAttribute, DaSubscriptionApp, DaSubscriptionFeature, DaSubscriptionPlan>
    {
        public DaSubscription() : base()
        { }
    }

    public class DaSubscription<TKey, TNullableKey, TSubscriptionAttribute, TSubscriptionApp, TSubscriptionFeature, TSubscriptionPlan> : DaEntityBase<TKey>, IDaSubscription<TKey, TNullableKey>
        where TKey : IEquatable<TKey>
        where TSubscriptionAttribute : IDaSubscriptionAttribute<TKey>
        where TSubscriptionApp : IDaSubscriptionApp<TKey>
        where TSubscriptionFeature : IDaSubscriptionFeature<TKey>
        where TSubscriptionPlan : IDaSubscriptionPlan<TKey, TNullableKey>
    {
        public DaSubscription()
        {
            Attributes = new HashSet<TSubscriptionAttribute>();
            SubscriptionApps = new HashSet<TSubscriptionApp>();
            SubscriptionFeatures = new HashSet<TSubscriptionFeature>();
        }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ExpiryDateUtc { get; set; }

        public TKey CurrencyId { get; set; }

        public TKey CountryId { get; set; }

        public decimal BillingAmount { get; set; }

        public DaBillingCycleType? BillingCycleType { get; set; }

        public int? BillingCycleStartDay { get; set; }

        public int? BillingCycleEndDay { get; set; }

        public TKey TenantId { get; set; }

        public TNullableKey UserAgreementVersionId { get; set; }

        public TKey OwnerUserId { get; set; }

        public TNullableKey PaymentMethodId { get; set; }

        public TKey SubscriptionPlanId { get; set; }

        public bool IsCurrentlyInTrial { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public virtual ICollection<TSubscriptionAttribute> Attributes { get; set; }

        public virtual ICollection<TSubscriptionApp> SubscriptionApps { get; set; }

        public virtual ICollection<TSubscriptionFeature> SubscriptionFeatures { get; set; }

        public virtual TSubscriptionPlan SubscriptionPlan { get; set; }

        public DateTime? TrialPeriodStartDateUtc { get; set; }

        public DateTime? TrialPeriodEndDateUtc { get; set; }

        public DateTime StartDateUtc { get; set; }

        public bool IsAutoRenew { get; set; }

        public string ReferenceNumber { get; set; }

        public DateTime? NextBillingDateUtc { get; set; }

        public DateTime StartDateAfterTrialUtc { get; set; }
    }
}
