﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using Ejyle.DevAccelerate.Core;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Tenants
{
    /// <summary>
    /// Represents the core interface for a tenant.
    /// </summary>
    /// <typeparam name="TKey">The type of a non-nullable key of an entity.</typeparam>
    /// <typeparam name="TNullableKey">The type of a nullable key of an entity.</typeparam>
    public interface IDaTenant<TKey, TNullableKey> : IDaEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Gets or sets the type of a tenant.
        /// </summary>
        DaTenantType TenantType { get; set; }

        /// <summary>
        /// Gets the name of a tenant.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the unique domain of a tenant.
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// Determines if the domain's ownership is verified or not.
        /// </summary>
        bool IsDomainOwnershipVerified { get; set; }

        /// <summary>
        /// Gets or sets the ID of the country of the tenant.
        /// </summary>
        TKey CountryId { get; set; }

        /// <summary>
        /// Gets or sets the currency ID of the tenant.
        /// </summary>
        TKey CurrencyId { get; set; }

        /// <summary>
        /// Gets or sets the time zone of the tenant.
        /// </summary>
        TKey TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the date and time format.
        /// </summary>
        TNullableKey DateFormatId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the date only format.
        /// </summary>
        TNullableKey DateFormatWithDateOnlyId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the time only format.
        /// </summary>
        TNullableKey DateFormatWithTimeOnlyId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the system language.
        /// </summary>
        TKey SystemLanguageId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who owns the tenant.
        /// </summary>
        TKey OwnerUserId { get; set; }

        /// <summary>
        /// Gets or sets the status of the tenant.
        /// </summary>
        DaTenantStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the user ID who created the tenant.
        /// </summary>
        TKey CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the tenant was created.
        /// </summary>
        DateTime CreatedDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the billing email of the tenant.
        /// </summary>
        string BillingEmail { get; set; }
    }
}
