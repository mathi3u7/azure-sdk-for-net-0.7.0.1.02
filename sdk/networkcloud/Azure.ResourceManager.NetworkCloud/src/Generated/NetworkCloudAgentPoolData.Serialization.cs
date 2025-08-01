// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudAgentPoolData : IUtf8JsonSerializable, IJsonModel<NetworkCloudAgentPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudAgentPoolData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudAgentPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudAgentPoolData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration, options);
            }
            if (Optional.IsDefined(AgentOptions))
            {
                writer.WritePropertyName("agentOptions"u8);
                writer.WriteObjectValue(AgentOptions, options);
            }
            if (Optional.IsDefined(AttachedNetworkConfiguration))
            {
                writer.WritePropertyName("attachedNetworkConfiguration"u8);
                writer.WriteObjectValue(AttachedNetworkConfiguration, options);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(KubernetesVersion))
            {
                writer.WritePropertyName("kubernetesVersion"u8);
                writer.WriteStringValue(KubernetesVersion);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Taints))
            {
                writer.WritePropertyName("taints"u8);
                writer.WriteStartArray();
                foreach (var item in Taints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings, options);
            }
            writer.WritePropertyName("vmSkuName"u8);
            writer.WriteStringValue(VmSkuName);
            writer.WriteEndObject();
        }

        NetworkCloudAgentPoolData IJsonModel<NetworkCloudAgentPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudAgentPoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudAgentPoolData(document.RootElement, options);
        }

        internal static NetworkCloudAgentPoolData DeserializeNetworkCloudAgentPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            AdministratorConfiguration administratorConfiguration = default;
            NetworkCloudAgentConfiguration agentOptions = default;
            AttachedNetworkConfiguration attachedNetworkConfiguration = default;
            IList<string> availabilityZones = default;
            long count = default;
            AgentPoolDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            string kubernetesVersion = default;
            IList<KubernetesLabel> labels = default;
            NetworkCloudAgentPoolMode mode = default;
            AgentPoolProvisioningState? provisioningState = default;
            IList<KubernetesLabel> taints = default;
            AgentPoolUpgradeSettings upgradeSettings = default;
            string vmSkuName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerNetworkCloudContext.Default);
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
                        if (property0.NameEquals("administratorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("agentOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentOptions = NetworkCloudAgentConfiguration.DeserializeNetworkCloudAgentConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("attachedNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            attachedNetworkConfiguration = AttachedNetworkConfiguration.DeserializeAttachedNetworkConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("availabilityZones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            availabilityZones = array;
                            continue;
                        }
                        if (property0.NameEquals("count"u8))
                        {
                            count = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new AgentPoolDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesLabel> array = new List<KubernetesLabel>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesLabel.DeserializeKubernetesLabel(item, options));
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            mode = new NetworkCloudAgentPoolMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AgentPoolProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesLabel> array = new List<KubernetesLabel>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesLabel.DeserializeKubernetesLabel(item, options));
                            }
                            taints = array;
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmSkuName"u8))
                        {
                            vmSkuName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkCloudAgentPoolData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                etag,
                extendedLocation,
                administratorConfiguration,
                agentOptions,
                attachedNetworkConfiguration,
                availabilityZones ?? new ChangeTrackingList<string>(),
                count,
                detailedStatus,
                detailedStatusMessage,
                kubernetesVersion,
                labels ?? new ChangeTrackingList<KubernetesLabel>(),
                mode,
                provisioningState,
                taints ?? new ChangeTrackingList<KubernetesLabel>(),
                upgradeSettings,
                vmSkuName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudAgentPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkCloudContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudAgentPoolData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudAgentPoolData IPersistableModel<NetworkCloudAgentPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkCloudAgentPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudAgentPoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudAgentPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
