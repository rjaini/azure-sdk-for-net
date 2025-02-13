// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties for evaluating a policy set. </summary>
    public partial class DevTestLabEvaluatePolicy
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePolicy"/>. </summary>
        public DevTestLabEvaluatePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePolicy"/>. </summary>
        /// <param name="factName"> The fact name. </param>
        /// <param name="factData"> The fact data. </param>
        /// <param name="valueOffset"> The value offset. </param>
        /// <param name="userObjectId"> The user for which policies will be evaluated. </param>
        internal DevTestLabEvaluatePolicy(string factName, string factData, string valueOffset, string userObjectId)
        {
            FactName = factName;
            FactData = factData;
            ValueOffset = valueOffset;
            UserObjectId = userObjectId;
        }

        /// <summary> The fact name. </summary>
        public string FactName { get; set; }
        /// <summary> The fact data. </summary>
        public string FactData { get; set; }
        /// <summary> The value offset. </summary>
        public string ValueOffset { get; set; }
        /// <summary> The user for which policies will be evaluated. </summary>
        public string UserObjectId { get; set; }
    }
}
