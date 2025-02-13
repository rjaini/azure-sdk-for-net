// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Extended Community Id list properties. </summary>
    internal partial class IPExtendedCommunityIdList
    {
        /// <summary> Initializes a new instance of <see cref="IPExtendedCommunityIdList"/>. </summary>
        public IPExtendedCommunityIdList()
        {
            IPExtendedCommunityIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="IPExtendedCommunityIdList"/>. </summary>
        /// <param name="ipExtendedCommunityIds"> List of IP Extended Community resource IDs. </param>
        internal IPExtendedCommunityIdList(IList<ResourceIdentifier> ipExtendedCommunityIds)
        {
            IPExtendedCommunityIds = ipExtendedCommunityIds;
        }

        /// <summary> List of IP Extended Community resource IDs. </summary>
        public IList<ResourceIdentifier> IPExtendedCommunityIds { get; }
    }
}
