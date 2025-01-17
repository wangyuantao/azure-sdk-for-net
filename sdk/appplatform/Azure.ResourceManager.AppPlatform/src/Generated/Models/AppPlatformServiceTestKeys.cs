// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Test keys payload. </summary>
    public partial class AppPlatformServiceTestKeys
    {
        /// <summary> Initializes a new instance of AppPlatformServiceTestKeys. </summary>
        internal AppPlatformServiceTestKeys()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformServiceTestKeys. </summary>
        /// <param name="primaryKey"> Primary key. </param>
        /// <param name="secondaryKey"> Secondary key. </param>
        /// <param name="primaryTestEndpoint"> Primary test endpoint. </param>
        /// <param name="secondaryTestEndpoint"> Secondary test endpoint. </param>
        /// <param name="isEnabled"> Indicates whether the test endpoint feature enabled or not. </param>
        internal AppPlatformServiceTestKeys(string primaryKey, string secondaryKey, string primaryTestEndpoint, string secondaryTestEndpoint, bool? isEnabled)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            PrimaryTestEndpoint = primaryTestEndpoint;
            SecondaryTestEndpoint = secondaryTestEndpoint;
            IsEnabled = isEnabled;
        }

        /// <summary> Primary key. </summary>
        public string PrimaryKey { get; }
        /// <summary> Secondary key. </summary>
        public string SecondaryKey { get; }
        /// <summary> Primary test endpoint. </summary>
        public string PrimaryTestEndpoint { get; }
        /// <summary> Secondary test endpoint. </summary>
        public string SecondaryTestEndpoint { get; }
        /// <summary> Indicates whether the test endpoint feature enabled or not. </summary>
        public bool? IsEnabled { get; }
    }
}
