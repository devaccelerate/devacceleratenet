﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ejyle.DevAccelerate.Core;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Tenants
{
    public class DaTenant : DaTenant<int, int?, DaTenantUser, DaTenantAttribute>
    {
        public DaTenant() : base()
        { }
    }

    public class DaTenant<TKey, TNullableKey, TTenantUser, TTenantAttribute> : DaEntityBase<TKey>, IDaTenant<TKey, TNullableKey>
        where TKey : IEquatable<TKey>
        where TTenantUser : IDaTenantUser<TKey>
        where TTenantAttribute : IDaTenantAttribute<TKey>
    {
        public DaTenant()
        {
            TenantUsers = new List<TTenantUser>();
        }

        public virtual ICollection<TTenantUser> TenantUsers { get; set; }
        public virtual ICollection<TTenantAttribute> Attributes { get; set; }

        [Required]
        public DaTenantType TenantType { get; set; }

        [Required]
        public TKey OwnerUserId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Domain { get; set; }

        [Required]
        public bool IsDomainOwnershipVerified { get; set; }

        [StringLength(256)]
        public string FriendlyName { get; set; }

        [Required]
        public DaTenantStatus Status { get; set; }

        public TKey CountryId { get; set; }

        public TKey CurrencyId { get; set; }

        public TKey TimeZoneId { get; set; }

        public string BillingEmail { get; set; }

        public TNullableKey DateFormatId { get; set; }

        public TNullableKey DateFormatWithDateOnlyId { get; set; }

        public TNullableKey DateFormatWithTimeOnlyId { get; set; }

        public TKey SystemLanguageId { get; set; }

        [Required]
        public TKey CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDateUtc { get; set; }
    }
}
