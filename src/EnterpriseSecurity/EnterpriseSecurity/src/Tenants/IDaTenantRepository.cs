﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Tenants
{
    /// <summary>
    /// Provides the interface for storing and retrieving tenants.
    /// </summary>
    /// <typeparam name="TKey">The type of an entity key.</typeparam>
    /// <typeparam name="TNullableKey">The type of a nullable key.</typeparam>
    /// <typeparam name="TTenant">The type of a tenant.</typeparam>
    public interface IDaTenantRepository<TKey, TNullableKey, TTenant> : IDaEntityRepository<TKey, TTenant>
        where TKey : IEquatable<TKey>
        where TTenant : IDaTenant<TKey, TNullableKey>
    {
        /// <summary>
        /// Asynchronously creates a tenant in the tenant repository.
        /// </summary>
        /// <param name="tenant">The tenant to create.</param>
        /// <returns>The Task that represents the asynchronous operation.</returns>
        Task CreateAsync(TTenant tenant);

        /// <summary>
        /// Asynchronously updates a tenant in the tenant repository.
        /// </summary>
        /// <param name="tenant">The tenant to be updated.</param>
        /// <returns>The Task that represents the asynchronous operation.</returns>
        Task UpdateAsync(TTenant tenant);

        /// <summary>
        /// Asynchronously finds and returns a tenant by its ID.
        /// </summary>
        /// <param name="tenantId">The ID of the tenant.</param>
        /// <returns>The Task that represents the asynchronous operation containing the matching tenant.</returns>
        Task<TTenant> FindByIdAsync(TKey tenantId);

        /// <summary>
        /// Asynchronously finds and returns a tenant by its name.
        /// </summary>
        /// <param name="name">The name of the tenant.</param>
        /// <returns>The Task that represents the asynchronous operation containing the matching tenant.</returns>
        Task<TTenant> FindByNameAsync(string name);

        /// <summary>
        /// Asynchronously finds and returns tenants associated with a given user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>The Task that represents the asynchronous operation containing the matching tenant.</returns>
        Task<List<TTenant>> FindByUserIdAsync(TKey userId);

        Task<bool> CheckTenantUserActiveAssociationAsync(TKey tenantId, TKey userId);
    }
}
