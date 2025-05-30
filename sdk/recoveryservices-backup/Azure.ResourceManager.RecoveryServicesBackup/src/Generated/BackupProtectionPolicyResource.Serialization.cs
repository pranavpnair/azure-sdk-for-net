// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    public partial class BackupProtectionPolicyResource : IJsonModel<BackupProtectionPolicyData>
    {
        void IJsonModel<BackupProtectionPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BackupProtectionPolicyData>)Data).Write(writer, options);

        BackupProtectionPolicyData IJsonModel<BackupProtectionPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BackupProtectionPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BackupProtectionPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BackupProtectionPolicyData>(Data, options, AzureResourceManagerRecoveryServicesBackupContext.Default);

        BackupProtectionPolicyData IPersistableModel<BackupProtectionPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BackupProtectionPolicyData>(data, options, AzureResourceManagerRecoveryServicesBackupContext.Default);

        string IPersistableModel<BackupProtectionPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BackupProtectionPolicyData>)Data).GetFormatFromOptions(options);
    }
}
