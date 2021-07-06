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
    /// SlackConnectionStatus
    /// </summary>
    [DataContract(Name = "SlackConnectionStatus")]
    public partial class SlackConnectionStatus : IEquatable<SlackConnectionStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackConnectionStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SlackConnectionStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackConnectionStatus" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        /// <param name="team">team (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="url">url (required).</param>
        public SlackConnectionStatus(bool ok = default(bool), string team = default(string), string user = default(string), string url = default(string))
        {
            this.Ok = ok;
            // to ensure "team" is required (not null)
            this.Team = team ?? throw new ArgumentNullException("team is a required property for SlackConnectionStatus and cannot be null");
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for SlackConnectionStatus and cannot be null");
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for SlackConnectionStatus and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name = "ok", IsRequired = true, EmitDefaultValue = true)]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", IsRequired = true, EmitDefaultValue = false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlackConnectionStatus {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as SlackConnectionStatus);
        }

        /// <summary>
        /// Returns true if SlackConnectionStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SlackConnectionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlackConnectionStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ok == input.Ok ||
                    this.Ok.Equals(input.Ok)
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

    }

}
