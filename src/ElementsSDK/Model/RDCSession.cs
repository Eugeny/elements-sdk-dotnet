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
    /// RDCSession
    /// </summary>
    [DataContract(Name = "RDCSession")]
    public partial class RDCSession : IEquatable<RDCSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RDCSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RDCSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RDCSession" /> class.
        /// </summary>
        /// <param name="user">user (required).</param>
        /// <param name="clientSession">clientSession (required).</param>
        /// <param name="hostWorkstation">hostWorkstation (required).</param>
        public RDCSession(ElementsUserMiniReference user = default(ElementsUserMiniReference), int clientSession = default(int), string hostWorkstation = default(string))
        {
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for RDCSession and cannot be null");
            this.ClientSession = clientSession;
            // to ensure "hostWorkstation" is required (not null)
            this.HostWorkstation = hostWorkstation ?? throw new ArgumentNullException("hostWorkstation is a required property for RDCSession and cannot be null");
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public ElementsUserMiniReference User { get; set; }

        /// <summary>
        /// Gets or Sets ClientSession
        /// </summary>
        [DataMember(Name = "client_session", IsRequired = true, EmitDefaultValue = false)]
        public int ClientSession { get; set; }

        /// <summary>
        /// Gets or Sets HostWorkstation
        /// </summary>
        [DataMember(Name = "host_workstation", IsRequired = true, EmitDefaultValue = false)]
        public string HostWorkstation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RDCSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ClientSession: ").Append(ClientSession).Append("\n");
            sb.Append("  HostWorkstation: ").Append(HostWorkstation).Append("\n");
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
            return this.Equals(input as RDCSession);
        }

        /// <summary>
        /// Returns true if RDCSession instances are equal
        /// </summary>
        /// <param name="input">Instance of RDCSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RDCSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.ClientSession == input.ClientSession ||
                    this.ClientSession.Equals(input.ClientSession)
                ) && 
                (
                    this.HostWorkstation == input.HostWorkstation ||
                    (this.HostWorkstation != null &&
                    this.HostWorkstation.Equals(input.HostWorkstation))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                hashCode = hashCode * 59 + this.ClientSession.GetHashCode();
                if (this.HostWorkstation != null)
                    hashCode = hashCode * 59 + this.HostWorkstation.GetHashCode();
                return hashCode;
            }
        }

    }

}
