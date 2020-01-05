﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using Ejyle.DevAccelerate.Core;

namespace Ejyle.DevAccelerate.EnterpriseSecurity.Apps
{
    public interface IDaAppAttribute<TKey> : IDaEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        TKey AppId { get; set; }
        string AttributeName { get; set; }
        string AttributeValue { get; set; }
        DateTime CreatedDateUtc { get; set; }
        DateTime LastUpdatedDateUtc { get; set; }
    }
}
