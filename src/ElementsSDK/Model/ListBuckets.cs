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
    /// ListBuckets
    /// </summary>
    [DataContract(Name = "ListBuckets")]
    public partial class ListBuckets : IEquatable<ListBuckets>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBuckets" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListBuckets() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBuckets" /> class.
        /// </summary>
        /// <param name="buckets">buckets (required).</param>
        public ListBuckets(List<string> buckets = default(List<string>))
        {
            // to ensure "buckets" is required (not null)
            this.Buckets = buckets ?? throw new ArgumentNullException("buckets is a required property for ListBuckets and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name = "buckets", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Buckets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBuckets {\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
            return this.Equals(input as ListBuckets);
        }

        /// <summary>
        /// Returns true if ListBuckets instances are equal
        /// </summary>
        /// <param name="input">Instance of ListBuckets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListBuckets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buckets == input.Buckets ||
                    this.Buckets != null &&
                    input.Buckets != null &&
                    this.Buckets.SequenceEqual(input.Buckets)
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
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                return hashCode;
            }
        }

    }

}
