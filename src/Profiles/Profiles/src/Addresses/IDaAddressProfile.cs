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

namespace Ejyle.DevAccelerate.Profiles.Addresses
{
    public interface IDaAddressProfile<TKey, TNullableKey> : IDaEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        string State { get; set; }
        TKey CountryId { get; set; }
        TKey OwnerUserId { get; set; }
        string PhoneNumber { get; set; }
        string AreaCode { get; set; }
        string Extension { get; set; }
        string FaxNumber { get; set; }
        double? Longitude { get; set; }
        double? Latitude { get; set; }
        DateTime CreatedDateUtc { get; set; }
        DateTime LastUpdatedDateUtc { get; set; }
    }
}
