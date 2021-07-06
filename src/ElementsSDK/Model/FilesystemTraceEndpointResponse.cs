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
    /// FilesystemTraceEndpointResponse
    /// </summary>
    [DataContract(Name = "FilesystemTraceEndpointResponse")]
    public partial class FilesystemTraceEndpointResponse : IEquatable<FilesystemTraceEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemTraceEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilesystemTraceEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemTraceEndpointResponse" /> class.
        /// </summary>
        /// <param name="root">root (required).</param>
        /// <param name="diskDRead">diskDRead (required).</param>
        /// <param name="diskDWrite">diskDWrite (required).</param>
        /// <param name="isFlat">isFlat (required).</param>
        public FilesystemTraceEndpointResponse(TraceNode root = default(TraceNode), int diskDRead = default(int), int diskDWrite = default(int), bool isFlat = default(bool))
        {
            // to ensure "root" is required (not null)
            this.Root = root ?? throw new ArgumentNullException("root is a required property for FilesystemTraceEndpointResponse and cannot be null");
            this.DiskDRead = diskDRead;
            this.DiskDWrite = diskDWrite;
            this.IsFlat = isFlat;
        }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", IsRequired = true, EmitDefaultValue = false)]
        public TraceNode Root { get; set; }

        /// <summary>
        /// Gets or Sets DiskDRead
        /// </summary>
        [DataMember(Name = "disk_d_read", IsRequired = true, EmitDefaultValue = false)]
        public int DiskDRead { get; set; }

        /// <summary>
        /// Gets or Sets DiskDWrite
        /// </summary>
        [DataMember(Name = "disk_d_write", IsRequired = true, EmitDefaultValue = false)]
        public int DiskDWrite { get; set; }

        /// <summary>
        /// Gets or Sets IsFlat
        /// </summary>
        [DataMember(Name = "is_flat", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFlat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesystemTraceEndpointResponse {\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  DiskDRead: ").Append(DiskDRead).Append("\n");
            sb.Append("  DiskDWrite: ").Append(DiskDWrite).Append("\n");
            sb.Append("  IsFlat: ").Append(IsFlat).Append("\n");
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
            return this.Equals(input as FilesystemTraceEndpointResponse);
        }

        /// <summary>
        /// Returns true if FilesystemTraceEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FilesystemTraceEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesystemTraceEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.DiskDRead == input.DiskDRead ||
                    this.DiskDRead.Equals(input.DiskDRead)
                ) && 
                (
                    this.DiskDWrite == input.DiskDWrite ||
                    this.DiskDWrite.Equals(input.DiskDWrite)
                ) && 
                (
                    this.IsFlat == input.IsFlat ||
                    this.IsFlat.Equals(input.IsFlat)
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
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                hashCode = hashCode * 59 + this.DiskDRead.GetHashCode();
                hashCode = hashCode * 59 + this.DiskDWrite.GetHashCode();
                hashCode = hashCode * 59 + this.IsFlat.GetHashCode();
                return hashCode;
            }
        }

    }

}
