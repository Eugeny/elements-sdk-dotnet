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
    /// ExternalTranscoderPartialUpdate
    /// </summary>
    [DataContract(Name = "ExternalTranscoderPartialUpdate")]
    public partial class ExternalTranscoderPartialUpdate : IEquatable<ExternalTranscoderPartialUpdate>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Transkoder for value: transkoder
            /// </summary>
            [EnumMember(Value = "transkoder")]
            Transkoder = 1,

            /// <summary>
            /// Enum Vantage for value: vantage
            /// </summary>
            [EnumMember(Value = "vantage")]
            Vantage = 2

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTranscoderPartialUpdate" /> class.
        /// </summary>
        /// <param name="pathMappings">pathMappings.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        public ExternalTranscoderPartialUpdate(List<string> pathMappings = default(List<string>), string name = default(string), TypeEnum? type = default(TypeEnum?), string address = default(string))
        {
            this.PathMappings = pathMappings;
            this.Name = name;
            this.Type = type;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets PathMappings
        /// </summary>
        [DataMember(Name = "path_mappings", EmitDefaultValue = false)]
        public List<string> PathMappings { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
            sb.Append("class ExternalTranscoderPartialUpdate {\n");
            sb.Append("  PathMappings: ").Append(PathMappings).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ExternalTranscoderPartialUpdate);
        }

        /// <summary>
        /// Returns true if ExternalTranscoderPartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalTranscoderPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTranscoderPartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PathMappings == input.PathMappings ||
                    this.PathMappings != null &&
                    input.PathMappings != null &&
                    this.PathMappings.SequenceEqual(input.PathMappings)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.PathMappings != null)
                    hashCode = hashCode * 59 + this.PathMappings.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }

    }

}
