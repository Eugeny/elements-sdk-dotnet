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
    /// WorkspaceCheckIn
    /// </summary>
    [DataContract(Name = "WorkspaceCheckIn")]
    public partial class WorkspaceCheckIn : IEquatable<WorkspaceCheckIn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCheckIn" /> class.
        /// </summary>
        /// <param name="mountpoint">mountpoint.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="address">address.</param>
        public WorkspaceCheckIn(string mountpoint = default(string), string protocol = default(string), string address = default(string))
        {
            this.Mountpoint = mountpoint;
            this.Protocol = protocol;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets Mountpoint
        /// </summary>
        [DataMember(Name = "mountpoint", EmitDefaultValue = false)]
        public string Mountpoint { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceCheckIn {\n");
            sb.Append("  Mountpoint: ").Append(Mountpoint).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as WorkspaceCheckIn);
        }

        /// <summary>
        /// Returns true if WorkspaceCheckIn instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceCheckIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceCheckIn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mountpoint == input.Mountpoint ||
                    (this.Mountpoint != null &&
                    this.Mountpoint.Equals(input.Mountpoint))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Mountpoint != null)
                    hashCode = hashCode * 59 + this.Mountpoint.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }

    }

}
