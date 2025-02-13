// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRequestRoutingRule : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayRequestRoutingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayRequestRoutingRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayRequestRoutingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRequestRoutingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRequestRoutingRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RuleType))
            {
                writer.WritePropertyName("ruleType"u8);
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                JsonSerializer.Serialize(writer, BackendHttpSettings);
            }
            if (Optional.IsDefined(HttpListener))
            {
                writer.WritePropertyName("httpListener"u8);
                JsonSerializer.Serialize(writer, HttpListener);
            }
            if (Optional.IsDefined(UrlPathMap))
            {
                writer.WritePropertyName("urlPathMap"u8);
                JsonSerializer.Serialize(writer, UrlPathMap);
            }
            if (Optional.IsDefined(RewriteRuleSet))
            {
                writer.WritePropertyName("rewriteRuleSet"u8);
                JsonSerializer.Serialize(writer, RewriteRuleSet);
            }
            if (Optional.IsDefined(RedirectConfiguration))
            {
                writer.WritePropertyName("redirectConfiguration"u8);
                JsonSerializer.Serialize(writer, RedirectConfiguration);
            }
            if (Optional.IsDefined(LoadDistributionPolicy))
            {
                writer.WritePropertyName("loadDistributionPolicy"u8);
                JsonSerializer.Serialize(writer, LoadDistributionPolicy);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApplicationGatewayRequestRoutingRule IJsonModel<ApplicationGatewayRequestRoutingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRequestRoutingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRequestRoutingRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRequestRoutingRule(document.RootElement, options);
        }

        internal static ApplicationGatewayRequestRoutingRule DeserializeApplicationGatewayRequestRoutingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ApplicationGatewayRequestRoutingRuleType> ruleType = default;
            Optional<int> priority = default;
            Optional<WritableSubResource> backendAddressPool = default;
            Optional<WritableSubResource> backendHttpSettings = default;
            Optional<WritableSubResource> httpListener = default;
            Optional<WritableSubResource> urlPathMap = default;
            Optional<WritableSubResource> rewriteRuleSet = default;
            Optional<WritableSubResource> redirectConfiguration = default;
            Optional<WritableSubResource> loadDistributionPolicy = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ruleType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleType = new ApplicationGatewayRequestRoutingRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendAddressPool = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("backendHttpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendHttpSettings = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("httpListener"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpListener = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("urlPathMap"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            urlPathMap = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("rewriteRuleSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rewriteRuleSet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("redirectConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loadDistributionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadDistributionPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayRequestRoutingRule(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, Optional.ToNullable(etag), Optional.ToNullable(ruleType), Optional.ToNullable(priority), backendAddressPool, backendHttpSettings, httpListener, urlPathMap, rewriteRuleSet, redirectConfiguration, loadDistributionPolicy, Optional.ToNullable(provisioningState));
        }

        BinaryData IPersistableModel<ApplicationGatewayRequestRoutingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRequestRoutingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRequestRoutingRule)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayRequestRoutingRule IPersistableModel<ApplicationGatewayRequestRoutingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRequestRoutingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayRequestRoutingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRequestRoutingRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayRequestRoutingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
