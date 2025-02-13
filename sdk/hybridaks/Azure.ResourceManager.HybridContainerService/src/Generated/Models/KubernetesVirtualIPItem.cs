// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The KubernetesVirtualIPItem. </summary>
    public partial class KubernetesVirtualIPItem
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesVirtualIPItem"/>. </summary>
        public KubernetesVirtualIPItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVirtualIPItem"/>. </summary>
        /// <param name="endIP"> Ending IP address for the IP Pool. </param>
        /// <param name="startIP"> Starting IP address for the IP Pool. </param>
        internal KubernetesVirtualIPItem(string endIP, string startIP)
        {
            EndIP = endIP;
            StartIP = startIP;
        }

        /// <summary> Ending IP address for the IP Pool. </summary>
        public string EndIP { get; set; }
        /// <summary> Starting IP address for the IP Pool. </summary>
        public string StartIP { get; set; }
    }
}
