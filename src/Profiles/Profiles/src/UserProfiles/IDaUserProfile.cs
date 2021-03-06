﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Profiles.UserProfiles
{
    public interface IDaUserProfile<TKey> : IDaEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        TKey UserId { get; set; }
        string Salutation { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string JobTitle { get; set; }
        string OrganizationName { get; set; }
        DateTime? Dob { get; set; }
        DaGender? Gender { get; set; }
        DateTime CreatedDateUtc { get; set; }
        DateTime LastUpdatedDateUtc { get; set; }
    }
}
