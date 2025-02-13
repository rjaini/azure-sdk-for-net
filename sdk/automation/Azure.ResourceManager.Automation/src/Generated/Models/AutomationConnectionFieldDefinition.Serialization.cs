// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationConnectionFieldDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEncrypted))
            {
                writer.WritePropertyName("isEncrypted"u8);
                writer.WriteBooleanValue(IsEncrypted.Value);
            }
            if (Optional.IsDefined(IsOptional))
            {
                writer.WritePropertyName("isOptional"u8);
                writer.WriteBooleanValue(IsOptional.Value);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FieldDefinitionType);
            writer.WriteEndObject();
        }

        internal static AutomationConnectionFieldDefinition DeserializeAutomationConnectionFieldDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isEncrypted = default;
            Optional<bool> isOptional = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOptional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new AutomationConnectionFieldDefinition(Optional.ToNullable(isEncrypted), Optional.ToNullable(isOptional), type);
        }
    }
}
