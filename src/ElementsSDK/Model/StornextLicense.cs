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
    /// StornextLicense
    /// </summary>
    [DataContract(Name = "StornextLicense")]
    public partial class StornextLicense : IEquatable<StornextLicense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StornextLicense" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StornextLicense() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StornextLicense" /> class.
        /// </summary>
        /// <param name="license">license (required).</param>
        public StornextLicense(string license = default(string))
        {
            // to ensure "license" is required (not null)
            this.License = license ?? throw new ArgumentNullException("license is a required property for StornextLicense and cannot be null");
        }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name = "license", IsRequired = true, EmitDefaultValue = false)]
        public string License { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StornextLicense {\n");
            sb.Append("  License: ").Append(License).Append("\n");
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
            return this.Equals(input as StornextLicense);
        }

        /// <summary>
        /// Returns true if StornextLicense instances are equal
        /// </summary>
        /// <param name="input">Instance of StornextLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StornextLicense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
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
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                return hashCode;
            }
        }

    }

}
