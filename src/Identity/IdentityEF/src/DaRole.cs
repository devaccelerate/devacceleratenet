﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Ejyle.DevAccelerate.Identity.EF
{
    /// <summary>
    /// Represents the non-generics version of the <see cref="DaRole{TKey, TUserRole}"/> class.
    /// </summary>
    public class DaRole : DaRole<int, DaUserRole>
    {
        /// <summary>
        /// Creates an instance of the <see cref="DaRole"/> class.
        /// </summary>
        public DaRole()
            : base()
        { }
    }

    /// <summary>
    /// Represents a role.
    /// </summary>
    /// <typeparam name="TKey">The type of the role ID.</typeparam>
    /// <typeparam name="TUserRole">The type of the user role.</typeparam>
    public class DaRole<TKey, TUserRole> : IdentityRole<TKey, TUserRole>, IDaRole<TKey>
        where TKey : IEquatable<TKey>
        where TUserRole : DaUserRole<TKey>
    {
        public const string GLOBAL_SUPER_ADMIN = "GlobalSuperAdmin";
        public const string TENANT_SUPER_ADMIN = "TenantSuperAdmin";
        public const string USER = "User";

        /// <summary>
        /// Creates an instance of the Role class.
        /// </summary>
        public DaRole()
            : base()
        { }
    }
}
