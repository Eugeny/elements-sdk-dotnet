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
    /// VolumeStats
    /// </summary>
    [DataContract(Name = "VolumeStats")]
    public partial class VolumeStats : IEquatable<VolumeStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VolumeStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeStats" /> class.
        /// </summary>
        /// <param name="usage">usage (required).</param>
        public VolumeStats(List<VolumeStat> usage = default(List<VolumeStat>))
        {
            // to ensure "usage" is required (not null)
            this.Usage = usage ?? throw new ArgumentNullException("usage is a required property for VolumeStats and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", IsRequired = true, EmitDefaultValue = false)]
        public List<VolumeStat> Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeStats {\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
            return this.Equals(input as VolumeStats);
        }

        /// <summary>
        /// Returns true if VolumeStats instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Usage == input.Usage ||
                    this.Usage != null &&
                    input.Usage != null &&
                    this.Usage.SequenceEqual(input.Usage)
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
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                return hashCode;
            }
        }

    }

}
