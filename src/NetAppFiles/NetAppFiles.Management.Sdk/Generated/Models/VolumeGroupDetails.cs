// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Volume group resource for create
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VolumeGroupDetails
    {
        /// <summary>
        /// Initializes a new instance of the VolumeGroupDetails class.
        /// </summary>
        public VolumeGroupDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeGroupDetails class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="groupMetaData">groupMetaData</param>
        /// <param name="volumes">List of volumes from group</param>
        public VolumeGroupDetails(string location = default(string), string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), VolumeGroupMetaData groupMetaData = default(VolumeGroupMetaData), IList<VolumeGroupVolumeProperties> volumes = default(IList<VolumeGroupVolumeProperties>))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            ProvisioningState = provisioningState;
            GroupMetaData = groupMetaData;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets groupMetaData
        /// </summary>
        /// <remarks>
        /// Volume group details
        /// </remarks>
        [JsonProperty(PropertyName = "properties.groupMetaData")]
        public VolumeGroupMetaData GroupMetaData { get; set; }

        /// <summary>
        /// Gets or sets list of volumes from group
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumes")]
        public IList<VolumeGroupVolumeProperties> Volumes { get; set; }

    }
}
