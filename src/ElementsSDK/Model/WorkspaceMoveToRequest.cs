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
    /// WorkspaceMoveToRequest
    /// </summary>
    [DataContract(Name = "WorkspaceMoveToRequest")]
    public partial class WorkspaceMoveToRequest : IEquatable<WorkspaceMoveToRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMoveToRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkspaceMoveToRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMoveToRequest" /> class.
        /// </summary>
        /// <param name="production">production (required).</param>
        public WorkspaceMoveToRequest(int production = default(int))
        {
            this.Production = production;
        }

        /// <summary>
        /// Gets or Sets Production
        /// </summary>
        [DataMember(Name = "production", IsRequired = true, EmitDefaultValue = false)]
        public int Production { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceMoveToRequest {\n");
            sb.Append("  Production: ").Append(Production).Append("\n");
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
            return this.Equals(input as WorkspaceMoveToRequest);
        }

        /// <summary>
        /// Returns true if WorkspaceMoveToRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceMoveToRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceMoveToRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Production == input.Production ||
                    this.Production.Equals(input.Production)
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
                hashCode = hashCode * 59 + this.Production.GetHashCode();
                return hashCode;
            }
        }

    }

}
