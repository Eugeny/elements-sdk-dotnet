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
    /// CustomFieldPartialUpdate
    /// </summary>
    [DataContract(Name = "CustomFieldPartialUpdate")]
    public partial class CustomFieldPartialUpdate : IEquatable<CustomFieldPartialUpdate>
    {
        /// <summary>
        /// Defines Validation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationEnum
        {
            /// <summary>
            /// Enum NumberOfDigits for value: number_of_digits
            /// </summary>
            [EnumMember(Value = "number_of_digits")]
            NumberOfDigits = 1,

            /// <summary>
            /// Enum Regex for value: regex
            /// </summary>
            [EnumMember(Value = "regex")]
            Regex = 2,

            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            [EnumMember(Value = "range")]
            Range = 3

        }


        /// <summary>
        /// Gets or Sets Validation
        /// </summary>
        [DataMember(Name = "validation", EmitDefaultValue = true)]
        public ValidationEnum? Validation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldPartialUpdate" /> class.
        /// </summary>
        /// <param name="labels">labels.</param>
        /// <param name="options">options.</param>
        /// <param name="name">name.</param>
        /// <param name="order">order.</param>
        /// <param name="type">type.</param>
        /// <param name="useForUploads">useForUploads.</param>
        /// <param name="requireToUpload">requireToUpload.</param>
        /// <param name="nonUserEditable">nonUserEditable.</param>
        /// <param name="validation">validation.</param>
        /// <param name="regex">regex.</param>
        /// <param name="rangeMin">rangeMin.</param>
        /// <param name="rangeMax">rangeMax.</param>
        /// <param name="numberOfDigits">numberOfDigits.</param>
        /// <param name="metadataPrefill">metadataPrefill.</param>
        /// <param name="highlightExpiration">highlightExpiration.</param>
        /// <param name="multipleResponse">multipleResponse.</param>
        /// <param name="helpText">helpText.</param>
        public CustomFieldPartialUpdate(List<string> labels = default(List<string>), List<string> options = default(List<string>), string name = default(string), int order = default(int), string type = default(string), bool useForUploads = default(bool), bool requireToUpload = default(bool), bool nonUserEditable = default(bool), ValidationEnum? validation = default(ValidationEnum?), string regex = default(string), int? rangeMin = default(int?), int? rangeMax = default(int?), int? numberOfDigits = default(int?), string metadataPrefill = default(string), bool highlightExpiration = default(bool), bool multipleResponse = default(bool), string helpText = default(string))
        {
            this.Labels = labels;
            this.Options = options;
            this.Name = name;
            this.Order = order;
            this.Type = type;
            this.UseForUploads = useForUploads;
            this.RequireToUpload = requireToUpload;
            this.NonUserEditable = nonUserEditable;
            this.Validation = validation;
            this.Regex = regex;
            this.RangeMin = rangeMin;
            this.RangeMax = rangeMax;
            this.NumberOfDigits = numberOfDigits;
            this.MetadataPrefill = metadataPrefill;
            this.HighlightExpiration = highlightExpiration;
            this.MultipleResponse = multipleResponse;
            this.HelpText = helpText;
        }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UseForUploads
        /// </summary>
        [DataMember(Name = "use_for_uploads", EmitDefaultValue = true)]
        public bool UseForUploads { get; set; }

        /// <summary>
        /// Gets or Sets RequireToUpload
        /// </summary>
        [DataMember(Name = "require_to_upload", EmitDefaultValue = true)]
        public bool RequireToUpload { get; set; }

        /// <summary>
        /// Gets or Sets NonUserEditable
        /// </summary>
        [DataMember(Name = "non_user_editable", EmitDefaultValue = true)]
        public bool NonUserEditable { get; set; }

        /// <summary>
        /// Gets or Sets Regex
        /// </summary>
        [DataMember(Name = "regex", EmitDefaultValue = true)]
        public string Regex { get; set; }

        /// <summary>
        /// Gets or Sets RangeMin
        /// </summary>
        [DataMember(Name = "range_min", EmitDefaultValue = true)]
        public int? RangeMin { get; set; }

        /// <summary>
        /// Gets or Sets RangeMax
        /// </summary>
        [DataMember(Name = "range_max", EmitDefaultValue = true)]
        public int? RangeMax { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDigits
        /// </summary>
        [DataMember(Name = "number_of_digits", EmitDefaultValue = true)]
        public int? NumberOfDigits { get; set; }

        /// <summary>
        /// Gets or Sets MetadataPrefill
        /// </summary>
        [DataMember(Name = "metadata_prefill", EmitDefaultValue = true)]
        public string MetadataPrefill { get; set; }

        /// <summary>
        /// Gets or Sets HighlightExpiration
        /// </summary>
        [DataMember(Name = "highlight_expiration", EmitDefaultValue = true)]
        public bool HighlightExpiration { get; set; }

        /// <summary>
        /// Gets or Sets MultipleResponse
        /// </summary>
        [DataMember(Name = "multiple_response", EmitDefaultValue = true)]
        public bool MultipleResponse { get; set; }

        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "help_text", EmitDefaultValue = true)]
        public string HelpText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFieldPartialUpdate {\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UseForUploads: ").Append(UseForUploads).Append("\n");
            sb.Append("  RequireToUpload: ").Append(RequireToUpload).Append("\n");
            sb.Append("  NonUserEditable: ").Append(NonUserEditable).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  RangeMin: ").Append(RangeMin).Append("\n");
            sb.Append("  RangeMax: ").Append(RangeMax).Append("\n");
            sb.Append("  NumberOfDigits: ").Append(NumberOfDigits).Append("\n");
            sb.Append("  MetadataPrefill: ").Append(MetadataPrefill).Append("\n");
            sb.Append("  HighlightExpiration: ").Append(HighlightExpiration).Append("\n");
            sb.Append("  MultipleResponse: ").Append(MultipleResponse).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
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
            return this.Equals(input as CustomFieldPartialUpdate);
        }

        /// <summary>
        /// Returns true if CustomFieldPartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomFieldPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFieldPartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UseForUploads == input.UseForUploads ||
                    this.UseForUploads.Equals(input.UseForUploads)
                ) && 
                (
                    this.RequireToUpload == input.RequireToUpload ||
                    this.RequireToUpload.Equals(input.RequireToUpload)
                ) && 
                (
                    this.NonUserEditable == input.NonUserEditable ||
                    this.NonUserEditable.Equals(input.NonUserEditable)
                ) && 
                (
                    this.Validation == input.Validation ||
                    this.Validation.Equals(input.Validation)
                ) && 
                (
                    this.Regex == input.Regex ||
                    (this.Regex != null &&
                    this.Regex.Equals(input.Regex))
                ) && 
                (
                    this.RangeMin == input.RangeMin ||
                    (this.RangeMin != null &&
                    this.RangeMin.Equals(input.RangeMin))
                ) && 
                (
                    this.RangeMax == input.RangeMax ||
                    (this.RangeMax != null &&
                    this.RangeMax.Equals(input.RangeMax))
                ) && 
                (
                    this.NumberOfDigits == input.NumberOfDigits ||
                    (this.NumberOfDigits != null &&
                    this.NumberOfDigits.Equals(input.NumberOfDigits))
                ) && 
                (
                    this.MetadataPrefill == input.MetadataPrefill ||
                    (this.MetadataPrefill != null &&
                    this.MetadataPrefill.Equals(input.MetadataPrefill))
                ) && 
                (
                    this.HighlightExpiration == input.HighlightExpiration ||
                    this.HighlightExpiration.Equals(input.HighlightExpiration)
                ) && 
                (
                    this.MultipleResponse == input.MultipleResponse ||
                    this.MultipleResponse.Equals(input.MultipleResponse)
                ) && 
                (
                    this.HelpText == input.HelpText ||
                    (this.HelpText != null &&
                    this.HelpText.Equals(input.HelpText))
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
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.UseForUploads.GetHashCode();
                hashCode = hashCode * 59 + this.RequireToUpload.GetHashCode();
                hashCode = hashCode * 59 + this.NonUserEditable.GetHashCode();
                hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.Regex != null)
                    hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.RangeMin != null)
                    hashCode = hashCode * 59 + this.RangeMin.GetHashCode();
                if (this.RangeMax != null)
                    hashCode = hashCode * 59 + this.RangeMax.GetHashCode();
                if (this.NumberOfDigits != null)
                    hashCode = hashCode * 59 + this.NumberOfDigits.GetHashCode();
                if (this.MetadataPrefill != null)
                    hashCode = hashCode * 59 + this.MetadataPrefill.GetHashCode();
                hashCode = hashCode * 59 + this.HighlightExpiration.GetHashCode();
                hashCode = hashCode * 59 + this.MultipleResponse.GetHashCode();
                if (this.HelpText != null)
                    hashCode = hashCode * 59 + this.HelpText.GetHashCode();
                return hashCode;
            }
        }

    }

}
