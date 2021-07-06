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
    /// SolrReindexEndpointResponse
    /// </summary>
    [DataContract(Name = "SolrReindexEndpointResponse")]
    public partial class SolrReindexEndpointResponse : IEquatable<SolrReindexEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolrReindexEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SolrReindexEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolrReindexEndpointResponse" /> class.
        /// </summary>
        /// <param name="tasks">tasks (required).</param>
        public SolrReindexEndpointResponse(List<TaskInfo> tasks = default(List<TaskInfo>))
        {
            // to ensure "tasks" is required (not null)
            this.Tasks = tasks ?? throw new ArgumentNullException("tasks is a required property for SolrReindexEndpointResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name = "tasks", IsRequired = true, EmitDefaultValue = false)]
        public List<TaskInfo> Tasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolrReindexEndpointResponse {\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
            return this.Equals(input as SolrReindexEndpointResponse);
        }

        /// <summary>
        /// Returns true if SolrReindexEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SolrReindexEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolrReindexEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
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
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                return hashCode;
            }
        }

    }

}
