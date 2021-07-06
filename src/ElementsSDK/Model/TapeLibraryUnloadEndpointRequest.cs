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
    /// TapeLibraryUnloadEndpointRequest
    /// </summary>
    [DataContract(Name = "TapeLibraryUnloadEndpointRequest")]
    public partial class TapeLibraryUnloadEndpointRequest : IEquatable<TapeLibraryUnloadEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TapeLibraryUnloadEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TapeLibraryUnloadEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TapeLibraryUnloadEndpointRequest" /> class.
        /// </summary>
        /// <param name="barcode">barcode (required).</param>
        public TapeLibraryUnloadEndpointRequest(string barcode = default(string))
        {
            // to ensure "barcode" is required (not null)
            this.Barcode = barcode ?? throw new ArgumentNullException("barcode is a required property for TapeLibraryUnloadEndpointRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "barcode", IsRequired = true, EmitDefaultValue = false)]
        public string Barcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TapeLibraryUnloadEndpointRequest {\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
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
            return this.Equals(input as TapeLibraryUnloadEndpointRequest);
        }

        /// <summary>
        /// Returns true if TapeLibraryUnloadEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TapeLibraryUnloadEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TapeLibraryUnloadEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
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
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                return hashCode;
            }
        }

    }

}
