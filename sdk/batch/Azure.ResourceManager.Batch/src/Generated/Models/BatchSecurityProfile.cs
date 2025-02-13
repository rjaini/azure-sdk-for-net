// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Specifies the security profile settings for the virtual machine or virtual machine scale set. </summary>
    public partial class BatchSecurityProfile
    {
        /// <summary> Initializes a new instance of <see cref="BatchSecurityProfile"/>. </summary>
        public BatchSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchSecurityProfile"/>. </summary>
        /// <param name="securityType"> Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable UefiSettings. </param>
        /// <param name="encryptionAtHost"> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. </param>
        /// <param name="uefiSettings"> Specifies the security settings like secure boot and vTPM used while creating the virtual machine. </param>
        internal BatchSecurityProfile(BatchSecurityType? securityType, bool? encryptionAtHost, BatchUefiSettings uefiSettings)
        {
            SecurityType = securityType;
            EncryptionAtHost = encryptionAtHost;
            UefiSettings = uefiSettings;
        }

        /// <summary> Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable UefiSettings. </summary>
        public BatchSecurityType? SecurityType { get; set; }
        /// <summary> This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. </summary>
        public bool? EncryptionAtHost { get; set; }
        /// <summary> Specifies the security settings like secure boot and vTPM used while creating the virtual machine. </summary>
        public BatchUefiSettings UefiSettings { get; set; }
    }
}
