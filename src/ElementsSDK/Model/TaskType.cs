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
    /// TaskType
    /// </summary>
    [DataContract(Name = "TaskType")]
    public partial class TaskType : IEquatable<TaskType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskType" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="displayGroup">displayGroup (required).</param>
        /// <param name="inputType">inputType (required).</param>
        /// <param name="abortable">abortable (required).</param>
        /// <param name="argTemplate">argTemplate (required).</param>
        /// <param name="requiredArgs">requiredArgs (required).</param>
        /// <param name="outputNames">outputNames (required).</param>
        /// <param name="parametersEditorComponent">parametersEditorComponent (required).</param>
        /// <param name="superuserOnly">superuserOnly (required).</param>
        /// <param name="iconClass">iconClass (required).</param>
        /// <param name="allowInJobs">allowInJobs (required).</param>
        /// <param name="newSinceVersion">newSinceVersion (required).</param>
        public TaskType(string type = default(string), string displayName = default(string), string displayGroup = default(string), string inputType = default(string), bool abortable = default(bool), Dictionary<string, string> argTemplate = default(Dictionary<string, string>), List<string> requiredArgs = default(List<string>), Dictionary<string, string> outputNames = default(Dictionary<string, string>), string parametersEditorComponent = default(string), bool superuserOnly = default(bool), string iconClass = default(string), bool allowInJobs = default(bool), string newSinceVersion = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TaskType and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for TaskType and cannot be null");
            // to ensure "displayGroup" is required (not null)
            this.DisplayGroup = displayGroup ?? throw new ArgumentNullException("displayGroup is a required property for TaskType and cannot be null");
            // to ensure "inputType" is required (not null)
            this.InputType = inputType ?? throw new ArgumentNullException("inputType is a required property for TaskType and cannot be null");
            this.Abortable = abortable;
            // to ensure "argTemplate" is required (not null)
            this.ArgTemplate = argTemplate ?? throw new ArgumentNullException("argTemplate is a required property for TaskType and cannot be null");
            // to ensure "requiredArgs" is required (not null)
            this.RequiredArgs = requiredArgs ?? throw new ArgumentNullException("requiredArgs is a required property for TaskType and cannot be null");
            // to ensure "outputNames" is required (not null)
            this.OutputNames = outputNames ?? throw new ArgumentNullException("outputNames is a required property for TaskType and cannot be null");
            // to ensure "parametersEditorComponent" is required (not null)
            this.ParametersEditorComponent = parametersEditorComponent ?? throw new ArgumentNullException("parametersEditorComponent is a required property for TaskType and cannot be null");
            this.SuperuserOnly = superuserOnly;
            // to ensure "iconClass" is required (not null)
            this.IconClass = iconClass ?? throw new ArgumentNullException("iconClass is a required property for TaskType and cannot be null");
            this.AllowInJobs = allowInJobs;
            // to ensure "newSinceVersion" is required (not null)
            this.NewSinceVersion = newSinceVersion ?? throw new ArgumentNullException("newSinceVersion is a required property for TaskType and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "display_name", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayGroup
        /// </summary>
        [DataMember(Name = "display_group", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayGroup { get; set; }

        /// <summary>
        /// Gets or Sets InputType
        /// </summary>
        [DataMember(Name = "input_type", IsRequired = true, EmitDefaultValue = true)]
        public string InputType { get; set; }

        /// <summary>
        /// Gets or Sets Abortable
        /// </summary>
        [DataMember(Name = "abortable", IsRequired = true, EmitDefaultValue = true)]
        public bool Abortable { get; set; }

        /// <summary>
        /// Gets or Sets ArgTemplate
        /// </summary>
        [DataMember(Name = "arg_template", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ArgTemplate { get; set; }

        /// <summary>
        /// Gets or Sets ArgTypes
        /// </summary>
        [DataMember(Name = "arg_types", EmitDefaultValue = false)]
        public Dictionary<string, ArgumentType> ArgTypes { get; private set; }

        /// <summary>
        /// Returns false as ArgTypes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeArgTypes()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets RequiredArgs
        /// </summary>
        [DataMember(Name = "required_args", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RequiredArgs { get; set; }

        /// <summary>
        /// Gets or Sets OutputNames
        /// </summary>
        [DataMember(Name = "output_names", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> OutputNames { get; set; }

        /// <summary>
        /// Gets or Sets OutputTypes
        /// </summary>
        [DataMember(Name = "output_types", EmitDefaultValue = false)]
        public Dictionary<string, ArgumentType> OutputTypes { get; private set; }

        /// <summary>
        /// Returns false as OutputTypes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOutputTypes()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets ParametersEditorComponent
        /// </summary>
        [DataMember(Name = "parameters_editor_component", IsRequired = true, EmitDefaultValue = true)]
        public string ParametersEditorComponent { get; set; }

        /// <summary>
        /// Gets or Sets SuperuserOnly
        /// </summary>
        [DataMember(Name = "superuser_only", IsRequired = true, EmitDefaultValue = true)]
        public bool SuperuserOnly { get; set; }

        /// <summary>
        /// Gets or Sets IconClass
        /// </summary>
        [DataMember(Name = "icon_class", IsRequired = true, EmitDefaultValue = true)]
        public string IconClass { get; set; }

        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name = "is_available", EmitDefaultValue = true)]
        public bool IsAvailable { get; private set; }

        /// <summary>
        /// Returns false as IsAvailable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsAvailable()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets AllowInJobs
        /// </summary>
        [DataMember(Name = "allow_in_jobs", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowInJobs { get; set; }

        /// <summary>
        /// Gets or Sets NewSinceVersion
        /// </summary>
        [DataMember(Name = "new_since_version", IsRequired = true, EmitDefaultValue = true)]
        public string NewSinceVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DisplayGroup: ").Append(DisplayGroup).Append("\n");
            sb.Append("  InputType: ").Append(InputType).Append("\n");
            sb.Append("  Abortable: ").Append(Abortable).Append("\n");
            sb.Append("  ArgTemplate: ").Append(ArgTemplate).Append("\n");
            sb.Append("  ArgTypes: ").Append(ArgTypes).Append("\n");
            sb.Append("  RequiredArgs: ").Append(RequiredArgs).Append("\n");
            sb.Append("  OutputNames: ").Append(OutputNames).Append("\n");
            sb.Append("  OutputTypes: ").Append(OutputTypes).Append("\n");
            sb.Append("  ParametersEditorComponent: ").Append(ParametersEditorComponent).Append("\n");
            sb.Append("  SuperuserOnly: ").Append(SuperuserOnly).Append("\n");
            sb.Append("  IconClass: ").Append(IconClass).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  AllowInJobs: ").Append(AllowInJobs).Append("\n");
            sb.Append("  NewSinceVersion: ").Append(NewSinceVersion).Append("\n");
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
            return this.Equals(input as TaskType);
        }

        /// <summary>
        /// Returns true if TaskType instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DisplayGroup == input.DisplayGroup ||
                    (this.DisplayGroup != null &&
                    this.DisplayGroup.Equals(input.DisplayGroup))
                ) && 
                (
                    this.InputType == input.InputType ||
                    (this.InputType != null &&
                    this.InputType.Equals(input.InputType))
                ) && 
                (
                    this.Abortable == input.Abortable ||
                    this.Abortable.Equals(input.Abortable)
                ) && 
                (
                    this.ArgTemplate == input.ArgTemplate ||
                    this.ArgTemplate != null &&
                    input.ArgTemplate != null &&
                    this.ArgTemplate.SequenceEqual(input.ArgTemplate)
                ) && 
                (
                    this.ArgTypes == input.ArgTypes ||
                    this.ArgTypes != null &&
                    input.ArgTypes != null &&
                    this.ArgTypes.SequenceEqual(input.ArgTypes)
                ) && 
                (
                    this.RequiredArgs == input.RequiredArgs ||
                    this.RequiredArgs != null &&
                    input.RequiredArgs != null &&
                    this.RequiredArgs.SequenceEqual(input.RequiredArgs)
                ) && 
                (
                    this.OutputNames == input.OutputNames ||
                    this.OutputNames != null &&
                    input.OutputNames != null &&
                    this.OutputNames.SequenceEqual(input.OutputNames)
                ) && 
                (
                    this.OutputTypes == input.OutputTypes ||
                    this.OutputTypes != null &&
                    input.OutputTypes != null &&
                    this.OutputTypes.SequenceEqual(input.OutputTypes)
                ) && 
                (
                    this.ParametersEditorComponent == input.ParametersEditorComponent ||
                    (this.ParametersEditorComponent != null &&
                    this.ParametersEditorComponent.Equals(input.ParametersEditorComponent))
                ) && 
                (
                    this.SuperuserOnly == input.SuperuserOnly ||
                    this.SuperuserOnly.Equals(input.SuperuserOnly)
                ) && 
                (
                    this.IconClass == input.IconClass ||
                    (this.IconClass != null &&
                    this.IconClass.Equals(input.IconClass))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    this.IsAvailable.Equals(input.IsAvailable)
                ) && 
                (
                    this.AllowInJobs == input.AllowInJobs ||
                    this.AllowInJobs.Equals(input.AllowInJobs)
                ) && 
                (
                    this.NewSinceVersion == input.NewSinceVersion ||
                    (this.NewSinceVersion != null &&
                    this.NewSinceVersion.Equals(input.NewSinceVersion))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DisplayGroup != null)
                    hashCode = hashCode * 59 + this.DisplayGroup.GetHashCode();
                if (this.InputType != null)
                    hashCode = hashCode * 59 + this.InputType.GetHashCode();
                hashCode = hashCode * 59 + this.Abortable.GetHashCode();
                if (this.ArgTemplate != null)
                    hashCode = hashCode * 59 + this.ArgTemplate.GetHashCode();
                if (this.ArgTypes != null)
                    hashCode = hashCode * 59 + this.ArgTypes.GetHashCode();
                if (this.RequiredArgs != null)
                    hashCode = hashCode * 59 + this.RequiredArgs.GetHashCode();
                if (this.OutputNames != null)
                    hashCode = hashCode * 59 + this.OutputNames.GetHashCode();
                if (this.OutputTypes != null)
                    hashCode = hashCode * 59 + this.OutputTypes.GetHashCode();
                if (this.ParametersEditorComponent != null)
                    hashCode = hashCode * 59 + this.ParametersEditorComponent.GetHashCode();
                hashCode = hashCode * 59 + this.SuperuserOnly.GetHashCode();
                if (this.IconClass != null)
                    hashCode = hashCode * 59 + this.IconClass.GetHashCode();
                hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                hashCode = hashCode * 59 + this.AllowInJobs.GetHashCode();
                if (this.NewSinceVersion != null)
                    hashCode = hashCode * 59 + this.NewSinceVersion.GetHashCode();
                return hashCode;
            }
        }

    }

}
