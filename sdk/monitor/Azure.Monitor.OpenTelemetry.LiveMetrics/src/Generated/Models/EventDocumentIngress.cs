// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Event type document. </summary>
    internal partial class EventDocumentIngress : DocumentIngress
    {
        /// <summary> Initializes a new instance of <see cref="EventDocumentIngress"/>. </summary>
        public EventDocumentIngress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventDocumentIngress"/>. </summary>
        /// <param name="documentType"> Telemetry type. Types not defined in enum will get replaced with a 'Unknown' type. </param>
        /// <param name="documentStreamIds"> An array of document streaming ids. Each id identifies a flow of documents customized by UX customers. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="additionalProperties"> Additional properties to be provided by a child type of DocumentIngress. </param>
        /// <param name="name"> Event name. </param>
        internal EventDocumentIngress(DocumentIngressDocumentType? documentType, IList<string> documentStreamIds, IList<KeyValuePairString> properties, string additionalProperties, string name) : base(documentType, documentStreamIds, properties, additionalProperties)
        {
            Name = name;
        }

        /// <summary> Event name. </summary>
        public string Name { get; set; }
    }
}
