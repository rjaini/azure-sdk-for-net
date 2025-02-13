// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes a network interface. </summary>
    public partial class HybridComputeNetworkInterface
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputeNetworkInterface"/>. </summary>
        internal HybridComputeNetworkInterface()
        {
            IPAddresses = new ChangeTrackingList<HybridComputeIPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeNetworkInterface"/>. </summary>
        /// <param name="ipAddresses"> The list of IP addresses in this interface. </param>
        internal HybridComputeNetworkInterface(IReadOnlyList<HybridComputeIPAddress> ipAddresses)
        {
            IPAddresses = ipAddresses;
        }

        /// <summary> The list of IP addresses in this interface. </summary>
        public IReadOnlyList<HybridComputeIPAddress> IPAddresses { get; }
    }
}
