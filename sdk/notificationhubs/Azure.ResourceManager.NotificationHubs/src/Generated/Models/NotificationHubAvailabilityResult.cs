// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a CheckAvailability resource. </summary>
    public partial class NotificationHubAvailabilityResult : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubAvailabilityResult(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="isAvailiable"> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        internal NotificationHubAvailabilityResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, bool? isAvailiable, NotificationHubSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            IsAvailiable = isAvailiable;
            Sku = sku;
        }

        /// <summary> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </summary>
        public bool? IsAvailiable { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
