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
    /// TestExternalTranscoderConnectionResponse
    /// </summary>
    [DataContract(Name = "TestExternalTranscoderConnectionResponse")]
    public partial class TestExternalTranscoderConnectionResponse : IEquatable<TestExternalTranscoderConnectionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestExternalTranscoderConnectionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestExternalTranscoderConnectionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestExternalTranscoderConnectionResponse" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        public TestExternalTranscoderConnectionResponse(bool ok = default(bool))
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name = "ok", IsRequired = true, EmitDefaultValue = true)]
        public bool Ok { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestExternalTranscoderConnectionResponse {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
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
            return this.Equals(input as TestExternalTranscoderConnectionResponse);
        }

        /// <summary>
        /// Returns true if TestExternalTranscoderConnectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TestExternalTranscoderConnectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestExternalTranscoderConnectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ok == input.Ok ||
                    this.Ok.Equals(input.Ok)
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
                hashCode = hashCode * 59 + this.Ok.GetHashCode();
                return hashCode;
            }
        }

    }

}
