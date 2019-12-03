﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Ejyle.DevAccelerate.Core;
using Ejyle.DevAccelerate.Core.Utils;

namespace Ejyle.DevAccelerate.Profiles.UserProfiles
{
    public class DaUserProfileManager<TKey, TUserProfile> : DaEntityManagerBase<TKey, TUserProfile>
        where TKey : IEquatable<TKey>
        where TUserProfile : IDaUserProfile<TKey>
    {
        public DaUserProfileManager(IDaUserProfileRepository<TKey, TUserProfile> repository) : base(repository)
        {
        }

        protected virtual IDaUserProfileRepository<TKey, TUserProfile> Repository
        {
            get
            {
                return GetRepository<IDaUserProfileRepository<TKey, TUserProfile>>();
            }
        }

        public virtual async Task CreateAsync(TUserProfile userProfile)
        {
            ThrowIfDisposed();
            ThrowIfArgumentIsNull(userProfile, nameof(userProfile));

            userProfile.CreatedDateUtc = DateTime.UtcNow;
            userProfile.LastUpdatedDateUtc = DateTime.UtcNow;

            await Repository.CreateAsync(userProfile);
        }

        public virtual void Create(TUserProfile userProfile)
        {
            DaAsyncHelper.RunSync(() => CreateAsync(userProfile));
        }

        public virtual async Task UpdateAsync(TUserProfile userProfile)
        {
            ThrowIfDisposed();
            ThrowIfArgumentIsNull(userProfile, nameof(userProfile));

            await Repository.UpdateAsync(userProfile);
        }

        public virtual void Update(TUserProfile userProfile)
        {
            DaAsyncHelper.RunSync(() => UpdateAsync(userProfile));
        }

        public virtual async Task DeleteAsync(TUserProfile userProfile)
        {
            ThrowIfDisposed();
            ThrowIfArgumentIsNull(userProfile, nameof(userProfile));

            await Repository.DeleteAsync(userProfile);
        }

        public virtual void Delete(TUserProfile userProfile)
        {
            DaAsyncHelper.RunSync(() => DeleteAsync(userProfile));
        }

        public virtual TUserProfile FindById(TKey id)
        {
            return DaAsyncHelper.RunSync<TUserProfile>(() => FindByIdAsync(id));
        }

        public virtual Task<TUserProfile> FindByIdAsync(TKey id)
        {
            ThrowIfDisposed();
            return Repository.FindByIdAsync(id);
        }
    }
}
