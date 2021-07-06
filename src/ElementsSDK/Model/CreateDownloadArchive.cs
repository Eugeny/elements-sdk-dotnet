/*
 * ELEMENTS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = ElementsSDK.Client.OpenAPIDateConverter;

namespace ElementsSDK.Model
{
    /// <summary>
    /// CreateDownloadArchive
    /// </summary>
    [DataContract(Name = "CreateDownloadArchive")]
    public partial class CreateDownloadArchive : IEquatable<CreateDownloadArchive>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDownloadArchive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDownloadArchive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDownloadArchive" /> class.
        /// </summary>
        /// <param name="paths">paths (required).</param>
        /// <param name="fileIds">fileIds.</param>
        /// <param name="bundleIds">bundleIds.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="forRoot">forRoot.</param>
        public CreateDownloadArchive(List<string> paths = default(List<string>), List<int> fileIds = default(List<int>), List<int> bundleIds = default(List<int>), bool proxy = default(bool), int forRoot = default(int))
        {
            // to ensure "paths" is required (not null)
            this.Paths = paths ?? throw new ArgumentNullException("paths is a required property for CreateDownloadArchive and cannot be null");
            this.FileIds = fileIds;
            this.BundleIds = bundleIds;
            this.Proxy = proxy;
            this.ForRoot = forRoot;
        }

        /// <summary>
        /// Gets or Sets Paths
        /// </summary>
        [DataMember(Name = "paths", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// Gets or Sets FileIds
        /// </summary>
        [DataMember(Name = "file_ids", EmitDefaultValue = false)]
        public List<int> FileIds { get; set; }

        /// <summary>
        /// Gets or Sets BundleIds
        /// </summary>
        [DataMember(Name = "bundle_ids", EmitDefaultValue = false)]
        public List<int> BundleIds { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "proxy", EmitDefaultValue = true)]
        public bool Proxy { get; set; }

        /// <summary>
        /// Gets or Sets ForRoot
        /// </summary>
        [DataMember(Name = "for_root", EmitDefaultValue = false)]
        public int ForRoot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDownloadArchive {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  BundleIds: ").Append(BundleIds).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  ForRoot: ").Append(ForRoot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDownloadArchive);
        }

        /// <summary>
        /// Returns true if CreateDownloadArchive instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDownloadArchive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDownloadArchive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                ) && 
                (
                    this.FileIds == input.FileIds ||
                    this.FileIds != null &&
                    input.FileIds != null &&
                    this.FileIds.SequenceEqual(input.FileIds)
                ) && 
                (
                    this.BundleIds == input.BundleIds ||
                    this.BundleIds != null &&
                    input.BundleIds != null &&
                    this.BundleIds.SequenceEqual(input.BundleIds)
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    this.Proxy.Equals(input.Proxy)
                ) && 
                (
                    this.ForRoot == input.ForRoot ||
                    this.ForRoot.Equals(input.ForRoot)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Paths != null)
                    hashCode = hashCode * 59 + this.Paths.GetHashCode();
                if (this.FileIds != null)
                    hashCode = hashCode * 59 + this.FileIds.GetHashCode();
                if (this.BundleIds != null)
                    hashCode = hashCode * 59 + this.BundleIds.GetHashCode();
                hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                hashCode = hashCode * 59 + this.ForRoot.GetHashCode();
                return hashCode;
            }
        }

    }

}
