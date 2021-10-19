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
    /// Job
    /// </summary>
    [DataContract(Name = "Job")]
    public partial class Job : IEquatable<Job>
    {
        /// <summary>
        /// Defines SpecialType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SpecialTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }


        /// <summary>
        /// Gets or Sets SpecialType
        /// </summary>
        [DataMember(Name = "special_type", EmitDefaultValue = true)]
        public SpecialTypeEnum? SpecialType { get; set; }
        /// <summary>
        /// Defines InputType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InputTypeEnum
        {
            /// <summary>
            /// Enum Path for value: path
            /// </summary>
            [EnumMember(Value = "path")]
            Path = 1,

            /// <summary>
            /// Enum Dir for value: dir
            /// </summary>
            [EnumMember(Value = "dir")]
            Dir = 2,

            /// <summary>
            /// Enum Paths for value: paths
            /// </summary>
            [EnumMember(Value = "paths")]
            Paths = 3,

            /// <summary>
            /// Enum Dirs for value: dirs
            /// </summary>
            [EnumMember(Value = "dirs")]
            Dirs = 4

        }


        /// <summary>
        /// Gets or Sets InputType
        /// </summary>
        [DataMember(Name = "input_type", EmitDefaultValue = true)]
        public InputTypeEnum? InputType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Job() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="subtasks">subtasks.</param>
        /// <param name="schedules">schedules.</param>
        /// <param name="allowUsers">allowUsers.</param>
        /// <param name="allowGroups">allowGroups.</param>
        /// <param name="variableDefinitions">variableDefinitions.</param>
        /// <param name="mediaRoots">mediaRoots.</param>
        /// <param name="specialType">specialType.</param>
        /// <param name="name">name (required).</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="allowOthersToStart">allowOthersToStart.</param>
        /// <param name="allowClientToStart">allowClientToStart.</param>
        /// <param name="showAsButton">showAsButton.</param>
        /// <param name="inputType">inputType.</param>
        /// <param name="hook">hook.</param>
        /// <param name="webhookSecret">webhookSecret.</param>
        /// <param name="securityContext">securityContext.</param>
        /// <param name="partOfWorkflowFor">partOfWorkflowFor.</param>
        public Job(List<SubtaskReference> subtasks = default(List<SubtaskReference>), List<ScheduleReference> schedules = default(List<ScheduleReference>), List<ElementsUserReference> allowUsers = default(List<ElementsUserReference>), List<ElementsGroupReference> allowGroups = default(List<ElementsGroupReference>), List<Dictionary<string, string>> variableDefinitions = default(List<Dictionary<string, string>>), List<int> mediaRoots = default(List<int>), SpecialTypeEnum? specialType = default(SpecialTypeEnum?), string name = default(string), bool enabled = default(bool), bool allowOthersToStart = default(bool), bool allowClientToStart = default(bool), bool showAsButton = default(bool), InputTypeEnum? inputType = default(InputTypeEnum?), string hook = default(string), string webhookSecret = default(string), int? securityContext = default(int?), int? partOfWorkflowFor = default(int?))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Job and cannot be null");
            this.Subtasks = subtasks;
            this.Schedules = schedules;
            this.AllowUsers = allowUsers;
            this.AllowGroups = allowGroups;
            this.VariableDefinitions = variableDefinitions;
            this.MediaRoots = mediaRoots;
            this.SpecialType = specialType;
            this.Enabled = enabled;
            this.AllowOthersToStart = allowOthersToStart;
            this.AllowClientToStart = allowClientToStart;
            this.ShowAsButton = showAsButton;
            this.InputType = inputType;
            this.Hook = hook;
            this.WebhookSecret = webhookSecret;
            this.SecurityContext = securityContext;
            this.PartOfWorkflowFor = partOfWorkflowFor;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Subtasks
        /// </summary>
        [DataMember(Name = "subtasks", EmitDefaultValue = false)]
        public List<SubtaskReference> Subtasks { get; set; }

        /// <summary>
        /// Gets or Sets Schedules
        /// </summary>
        [DataMember(Name = "schedules", EmitDefaultValue = false)]
        public List<ScheduleReference> Schedules { get; set; }

        /// <summary>
        /// Gets or Sets AllowUsers
        /// </summary>
        [DataMember(Name = "allow_users", EmitDefaultValue = false)]
        public List<ElementsUserReference> AllowUsers { get; set; }

        /// <summary>
        /// Gets or Sets AllowGroups
        /// </summary>
        [DataMember(Name = "allow_groups", EmitDefaultValue = false)]
        public List<ElementsGroupReference> AllowGroups { get; set; }

        /// <summary>
        /// Gets or Sets Startable
        /// </summary>
        [DataMember(Name = "startable", EmitDefaultValue = true)]
        public bool Startable { get; private set; }

        /// <summary>
        /// Returns false as Startable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartable()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VariableDefinitions
        /// </summary>
        [DataMember(Name = "variable_definitions", EmitDefaultValue = false)]
        public List<Dictionary<string, string>> VariableDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets MediaRoots
        /// </summary>
        [DataMember(Name = "media_roots", EmitDefaultValue = false)]
        public List<int> MediaRoots { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name = "webhook_url", EmitDefaultValue = false)]
        public string WebhookUrl { get; private set; }

        /// <summary>
        /// Returns false as WebhookUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWebhookUrl()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets AllowOthersToStart
        /// </summary>
        [DataMember(Name = "allow_others_to_start", EmitDefaultValue = true)]
        public bool AllowOthersToStart { get; set; }

        /// <summary>
        /// Gets or Sets AllowClientToStart
        /// </summary>
        [DataMember(Name = "allow_client_to_start", EmitDefaultValue = true)]
        public bool AllowClientToStart { get; set; }

        /// <summary>
        /// Gets or Sets ShowAsButton
        /// </summary>
        [DataMember(Name = "show_as_button", EmitDefaultValue = true)]
        public bool ShowAsButton { get; set; }

        /// <summary>
        /// Gets or Sets Hook
        /// </summary>
        [DataMember(Name = "hook", EmitDefaultValue = true)]
        public string Hook { get; set; }

        /// <summary>
        /// Gets or Sets WebhookSecret
        /// </summary>
        [DataMember(Name = "webhook_secret", EmitDefaultValue = true)]
        public string WebhookSecret { get; set; }

        /// <summary>
        /// Gets or Sets SecurityContext
        /// </summary>
        [DataMember(Name = "security_context", EmitDefaultValue = true)]
        public int? SecurityContext { get; set; }

        /// <summary>
        /// Gets or Sets PartOfWorkflowFor
        /// </summary>
        [DataMember(Name = "part_of_workflow_for", EmitDefaultValue = true)]
        public int? PartOfWorkflowFor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Subtasks: ").Append(Subtasks).Append("\n");
            sb.Append("  Schedules: ").Append(Schedules).Append("\n");
            sb.Append("  AllowUsers: ").Append(AllowUsers).Append("\n");
            sb.Append("  AllowGroups: ").Append(AllowGroups).Append("\n");
            sb.Append("  Startable: ").Append(Startable).Append("\n");
            sb.Append("  VariableDefinitions: ").Append(VariableDefinitions).Append("\n");
            sb.Append("  MediaRoots: ").Append(MediaRoots).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  SpecialType: ").Append(SpecialType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  AllowOthersToStart: ").Append(AllowOthersToStart).Append("\n");
            sb.Append("  AllowClientToStart: ").Append(AllowClientToStart).Append("\n");
            sb.Append("  ShowAsButton: ").Append(ShowAsButton).Append("\n");
            sb.Append("  InputType: ").Append(InputType).Append("\n");
            sb.Append("  Hook: ").Append(Hook).Append("\n");
            sb.Append("  WebhookSecret: ").Append(WebhookSecret).Append("\n");
            sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  PartOfWorkflowFor: ").Append(PartOfWorkflowFor).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Subtasks == input.Subtasks ||
                    this.Subtasks != null &&
                    input.Subtasks != null &&
                    this.Subtasks.SequenceEqual(input.Subtasks)
                ) && 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    input.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
                ) && 
                (
                    this.AllowUsers == input.AllowUsers ||
                    this.AllowUsers != null &&
                    input.AllowUsers != null &&
                    this.AllowUsers.SequenceEqual(input.AllowUsers)
                ) && 
                (
                    this.AllowGroups == input.AllowGroups ||
                    this.AllowGroups != null &&
                    input.AllowGroups != null &&
                    this.AllowGroups.SequenceEqual(input.AllowGroups)
                ) && 
                (
                    this.Startable == input.Startable ||
                    this.Startable.Equals(input.Startable)
                ) && 
                (
                    this.VariableDefinitions == input.VariableDefinitions ||
                    this.VariableDefinitions != null &&
                    input.VariableDefinitions != null &&
                    this.VariableDefinitions.SequenceEqual(input.VariableDefinitions)
                ) && 
                (
                    this.MediaRoots == input.MediaRoots ||
                    this.MediaRoots != null &&
                    input.MediaRoots != null &&
                    this.MediaRoots.SequenceEqual(input.MediaRoots)
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.SpecialType == input.SpecialType ||
                    this.SpecialType.Equals(input.SpecialType)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.AllowOthersToStart == input.AllowOthersToStart ||
                    this.AllowOthersToStart.Equals(input.AllowOthersToStart)
                ) && 
                (
                    this.AllowClientToStart == input.AllowClientToStart ||
                    this.AllowClientToStart.Equals(input.AllowClientToStart)
                ) && 
                (
                    this.ShowAsButton == input.ShowAsButton ||
                    this.ShowAsButton.Equals(input.ShowAsButton)
                ) && 
                (
                    this.InputType == input.InputType ||
                    this.InputType.Equals(input.InputType)
                ) && 
                (
                    this.Hook == input.Hook ||
                    (this.Hook != null &&
                    this.Hook.Equals(input.Hook))
                ) && 
                (
                    this.WebhookSecret == input.WebhookSecret ||
                    (this.WebhookSecret != null &&
                    this.WebhookSecret.Equals(input.WebhookSecret))
                ) && 
                (
                    this.SecurityContext == input.SecurityContext ||
                    (this.SecurityContext != null &&
                    this.SecurityContext.Equals(input.SecurityContext))
                ) && 
                (
                    this.PartOfWorkflowFor == input.PartOfWorkflowFor ||
                    (this.PartOfWorkflowFor != null &&
                    this.PartOfWorkflowFor.Equals(input.PartOfWorkflowFor))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Subtasks != null)
                    hashCode = hashCode * 59 + this.Subtasks.GetHashCode();
                if (this.Schedules != null)
                    hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.AllowUsers != null)
                    hashCode = hashCode * 59 + this.AllowUsers.GetHashCode();
                if (this.AllowGroups != null)
                    hashCode = hashCode * 59 + this.AllowGroups.GetHashCode();
                hashCode = hashCode * 59 + this.Startable.GetHashCode();
                if (this.VariableDefinitions != null)
                    hashCode = hashCode * 59 + this.VariableDefinitions.GetHashCode();
                if (this.MediaRoots != null)
                    hashCode = hashCode * 59 + this.MediaRoots.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                hashCode = hashCode * 59 + this.SpecialType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.AllowOthersToStart.GetHashCode();
                hashCode = hashCode * 59 + this.AllowClientToStart.GetHashCode();
                hashCode = hashCode * 59 + this.ShowAsButton.GetHashCode();
                hashCode = hashCode * 59 + this.InputType.GetHashCode();
                if (this.Hook != null)
                    hashCode = hashCode * 59 + this.Hook.GetHashCode();
                if (this.WebhookSecret != null)
                    hashCode = hashCode * 59 + this.WebhookSecret.GetHashCode();
                if (this.SecurityContext != null)
                    hashCode = hashCode * 59 + this.SecurityContext.GetHashCode();
                if (this.PartOfWorkflowFor != null)
                    hashCode = hashCode * 59 + this.PartOfWorkflowFor.GetHashCode();
                return hashCode;
            }
        }

    }

}
