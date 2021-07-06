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
    /// LDAPServerUsers
    /// </summary>
    [DataContract(Name = "LDAPServerUsers")]
    public partial class LDAPServerUsers : IEquatable<LDAPServerUsers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPServerUsers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LDAPServerUsers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPServerUsers" /> class.
        /// </summary>
        /// <param name="users">users (required).</param>
        public LDAPServerUsers(List<LDAPServerUser> users = default(List<LDAPServerUser>))
        {
            // to ensure "users" is required (not null)
            this.Users = users ?? throw new ArgumentNullException("users is a required property for LDAPServerUsers and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", IsRequired = true, EmitDefaultValue = false)]
        public List<LDAPServerUser> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LDAPServerUsers {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as LDAPServerUsers);
        }

        /// <summary>
        /// Returns true if LDAPServerUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of LDAPServerUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LDAPServerUsers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }

    }

}
