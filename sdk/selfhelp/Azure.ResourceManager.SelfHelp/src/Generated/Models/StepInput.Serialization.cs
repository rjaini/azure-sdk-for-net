// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class StepInput
    {
        internal static StepInput DeserializeStepInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> questionId = default;
            Optional<string> questionType = default;
            Optional<string> questionContent = default;
            Optional<QuestionContentType> questionContentType = default;
            Optional<string> responseHint = default;
            Optional<string> recommendedOption = default;
            Optional<string> selectedOptionValue = default;
            Optional<ResponseValidationProperties> responseValidationProperties = default;
            Optional<IReadOnlyList<ResponseConfig>> responseOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("questionId"u8))
                {
                    questionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionType"u8))
                {
                    questionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionContent"u8))
                {
                    questionContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionContentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    questionContentType = new QuestionContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("responseHint"u8))
                {
                    responseHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedOption"u8))
                {
                    recommendedOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedOptionValue"u8))
                {
                    selectedOptionValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responseValidationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseValidationProperties = ResponseValidationProperties.DeserializeResponseValidationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("responseOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseConfig> array = new List<ResponseConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResponseConfig.DeserializeResponseConfig(item));
                    }
                    responseOptions = array;
                    continue;
                }
            }
            return new StepInput(questionId.Value, questionType.Value, questionContent.Value, Optional.ToNullable(questionContentType), responseHint.Value, recommendedOption.Value, selectedOptionValue.Value, responseValidationProperties.Value, Optional.ToList(responseOptions));
        }
    }
}
