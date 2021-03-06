﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Apps
{
    public interface IDaFeatureRepository<TKey, TNullableKey, TFeature> : IDaEntityRepository<TKey, TFeature>
        where TKey : IEquatable<TKey>
        where TFeature : IDaFeature<TKey, TNullableKey>
    {
        Task CreateAsync(TFeature feature);
        Task<TFeature> FindByIdAsync(TKey id);
        Task<TFeature> FindByKeyAsync(string key);
        Task<List<TFeature>> FindAllAsync();
        Task<List<TFeature>> FindByAppIdAsync(TNullableKey appId);
        Task UpdateAsync(TFeature feature);
        Task DeleteAsync(TFeature feature);
    }
}
