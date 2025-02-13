// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileMachineInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EsuProfile))
            {
                writer.WritePropertyName("esuProfile"u8);
                writer.WriteObjectValue(EsuProfile);
            }
            writer.WritePropertyName("productProfile"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SubscriptionStatus))
            {
                writer.WritePropertyName("subscriptionStatus"u8);
                writer.WriteStringValue(SubscriptionStatus.Value.ToString());
            }
            if (Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ProductFeatures))
            {
                writer.WritePropertyName("productFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in ProductFeatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WritePropertyName("softwareAssurance"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsSoftwareAssuranceCustomer))
            {
                writer.WritePropertyName("softwareAssuranceCustomer"u8);
                writer.WriteBooleanValue(IsSoftwareAssuranceCustomer.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LicenseProfileMachineInstanceView DeserializeLicenseProfileMachineInstanceView(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridComputeLicenseStatus> licenseStatus = default;
            Optional<string> licenseChannel = default;
            Optional<LicenseProfileMachineInstanceViewEsuProperties> esuProfile = default;
            Optional<LicenseProfileSubscriptionStatus> subscriptionStatus = default;
            Optional<LicenseProfileProductType> productType = default;
            Optional<DateTimeOffset> billingStartDate = default;
            Optional<DateTimeOffset> enrollmentDate = default;
            Optional<DateTimeOffset> disenrollmentDate = default;
            Optional<IList<HybridComputeProductFeature>> productFeatures = default;
            Optional<bool> softwareAssuranceCustomer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("licenseStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseStatus = new HybridComputeLicenseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("licenseChannel"u8))
                {
                    licenseChannel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("esuProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuProfile = LicenseProfileMachineInstanceViewEsuProperties.DeserializeLicenseProfileMachineInstanceViewEsuProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("productProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subscriptionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionStatus = new LicenseProfileSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productType = new LicenseProfileProductType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("enrollmentDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enrollmentDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("disenrollmentDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disenrollmentDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HybridComputeProductFeature> array = new List<HybridComputeProductFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HybridComputeProductFeature.DeserializeHybridComputeProductFeature(item));
                            }
                            productFeatures = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("softwareAssurance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("softwareAssuranceCustomer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softwareAssuranceCustomer = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LicenseProfileMachineInstanceView(Optional.ToNullable(licenseStatus), licenseChannel.Value, esuProfile.Value, Optional.ToNullable(subscriptionStatus), Optional.ToNullable(productType), Optional.ToNullable(billingStartDate), Optional.ToNullable(enrollmentDate), Optional.ToNullable(disenrollmentDate), Optional.ToList(productFeatures), Optional.ToNullable(softwareAssuranceCustomer));
        }
    }
}
