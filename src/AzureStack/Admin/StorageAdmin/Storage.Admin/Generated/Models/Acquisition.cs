// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The acquisition of the page BLOB.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Acquisition : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Acquisition class.
        /// </summary>
        public Acquisition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Acquisition class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="filePath">The file path of the page BLOB file on
        /// storage cluster.</param>
        /// <param name="maximumblobsize">The maximum size of the page
        /// BLOB.</param>
        /// <param name="status">The status of the page BLOB acquisition.
        /// Possible values include: 'InProgress', 'Success', 'Failed'</param>
        /// <param name="susbcriptionid">ID of the subscription associated with
        /// the page BLOB.</param>
        /// <param name="storageaccount">The storage account that holds the
        /// page BLOB.</param>
        /// <param name="container">The container associated with the the page
        /// BLOB.</param>
        /// <param name="blob">The name of the page BLOB.</param>
        /// <param name="acquisitionid">The ID of page BLOB
        /// acquisition.</param>
        public Acquisition(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string filePath = default(string), long? maximumblobsize = default(long?), string status = default(string), string susbcriptionid = default(string), string storageaccount = default(string), string container = default(string), string blob = default(string), string acquisitionid = default(string))
            : base(id, name, type, location, tags)
        {
            FilePath = filePath;
            Maximumblobsize = maximumblobsize;
            Status = status;
            Susbcriptionid = susbcriptionid;
            Storageaccount = storageaccount;
            Container = container;
            Blob = blob;
            Acquisitionid = acquisitionid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the file path of the page BLOB file on storage cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filePath")]
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the maximum size of the page BLOB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumblobsize")]
        public long? Maximumblobsize { get; private set; }

        /// <summary>
        /// Gets the status of the page BLOB acquisition. Possible values
        /// include: 'InProgress', 'Success', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets ID of the subscription associated with the page BLOB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.susbcriptionid")]
        public string Susbcriptionid { get; private set; }

        /// <summary>
        /// Gets the storage account that holds the page BLOB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageaccount")]
        public string Storageaccount { get; private set; }

        /// <summary>
        /// Gets the container associated with the the page BLOB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.container")]
        public string Container { get; private set; }

        /// <summary>
        /// Gets the name of the page BLOB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blob")]
        public string Blob { get; private set; }

        /// <summary>
        /// Gets the ID of page BLOB acquisition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.acquisitionid")]
        public string Acquisitionid { get; private set; }

    }
}
