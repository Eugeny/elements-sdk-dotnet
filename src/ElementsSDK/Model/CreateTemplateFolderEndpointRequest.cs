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
    /// CreateTemplateFolderEndpointRequest
    /// </summary>
    [DataContract(Name = "CreateTemplateFolderEndpointRequest")]
    public partial class CreateTemplateFolderEndpointRequest : IEquatable<CreateTemplateFolderEndpointRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateFolderEndpointRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTemplateFolderEndpointRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateFolderEndpointRequest" /> class.
        /// </summary>
        /// <param name="group">group.</param>
        /// <param name="template">template (required).</param>
        /// <param name="path">path (required).</param>
        public CreateTemplateFolderEndpointRequest(int? group = default(int?), string template = default(string), string path = default(string))
        {
            // to ensure "template" is required (not null)
            this.Template = template ?? throw new ArgumentNullException("template is a required property for CreateTemplateFolderEndpointRequest and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for CreateTemplateFolderEndpointRequest and cannot be null");
            this.Group = group;
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public int? Group { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", IsRequired = true, EmitDefaultValue = false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateFolderEndpointRequest {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as CreateTemplateFolderEndpointRequest);
        }

        /// <summary>
        /// Returns true if CreateTemplateFolderEndpointRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTemplateFolderEndpointRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTemplateFolderEndpointRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}
