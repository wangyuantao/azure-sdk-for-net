// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataExportDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("transferConfiguration");
            writer.WriteObjectValue(TransferConfiguration);
            if (Optional.IsDefined(LogCollectionLevel))
            {
                writer.WritePropertyName("logCollectionLevel");
                writer.WriteStringValue(LogCollectionLevel.Value.ToSerialString());
            }
            writer.WritePropertyName("accountDetails");
            writer.WriteObjectValue(AccountDetails);
            writer.WriteEndObject();
        }

        internal static DataExportDetails DeserializeDataExportDetails(JsonElement element)
        {
            TransferConfiguration transferConfiguration = default;
            Optional<LogCollectionLevel> logCollectionLevel = default;
            DataAccountDetails accountDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transferConfiguration"))
                {
                    transferConfiguration = TransferConfiguration.DeserializeTransferConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("logCollectionLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logCollectionLevel = property.Value.GetString().ToLogCollectionLevel();
                    continue;
                }
                if (property.NameEquals("accountDetails"))
                {
                    accountDetails = DataAccountDetails.DeserializeDataAccountDetails(property.Value);
                    continue;
                }
            }
            return new DataExportDetails(transferConfiguration, Optional.ToNullable(logCollectionLevel), accountDetails);
        }
    }
}
