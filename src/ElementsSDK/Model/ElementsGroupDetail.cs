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
    /// ElementsGroupDetail
    /// </summary>
    [DataContract(Name = "ElementsGroupDetail")]
    public partial class ElementsGroupDetail : IEquatable<ElementsGroupDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementsGroupDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElementsGroupDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementsGroupDetail" /> class.
        /// </summary>
        /// <param name="permissions">permissions.</param>
        /// <param name="members">members.</param>
        /// <param name="ldap">ldap.</param>
        /// <param name="name">name (required).</param>
        /// <param name="ldapDn">ldapDn.</param>
        /// <param name="unixGroupname">unixGroupname.</param>
        /// <param name="gid">gid.</param>
        /// <param name="ancillaryPath">ancillaryPath.</param>
        /// <param name="ancillaryPathReadOnly">ancillaryPathReadOnly.</param>
        public ElementsGroupDetail(List<string> permissions = default(List<string>), List<ElementsUserReference> members = default(List<ElementsUserReference>), LDAPServerReference ldap = default(LDAPServerReference), string name = default(string), string ldapDn = default(string), string unixGroupname = default(string), int? gid = default(int?), string ancillaryPath = default(string), bool ancillaryPathReadOnly = default(bool))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ElementsGroupDetail and cannot be null");
            this.Permissions = permissions;
            this.Members = members;
            this.Ldap = ldap;
            this.LdapDn = ldapDn;
            this.UnixGroupname = unixGroupname;
            this.Gid = gid;
            this.AncillaryPath = ancillaryPath;
            this.AncillaryPathReadOnly = ancillaryPathReadOnly;
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
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets MembersPreview
        /// </summary>
        [DataMember(Name = "members_preview", EmitDefaultValue = false)]
        public List<MemberPreview> MembersPreview { get; private set; }

        /// <summary>
        /// Returns false as MembersPreview should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMembersPreview()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets EffectivePermissions
        /// </summary>
        [DataMember(Name = "effective_permissions", EmitDefaultValue = false)]
        public List<string> EffectivePermissions { get; private set; }

        /// <summary>
        /// Returns false as EffectivePermissions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEffectivePermissions()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false)]
        public List<ElementsUserReference> Members { get; set; }

        /// <summary>
        /// Gets or Sets Ldap
        /// </summary>
        [DataMember(Name = "ldap", EmitDefaultValue = false)]
        public LDAPServerReference Ldap { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LdapDn
        /// </summary>
        [DataMember(Name = "ldap_dn", EmitDefaultValue = true)]
        public string LdapDn { get; set; }

        /// <summary>
        /// Gets or Sets UnixGroupname
        /// </summary>
        [DataMember(Name = "unix_groupname", EmitDefaultValue = true)]
        public string UnixGroupname { get; set; }

        /// <summary>
        /// Gets or Sets Gid
        /// </summary>
        [DataMember(Name = "gid", EmitDefaultValue = true)]
        public int? Gid { get; set; }

        /// <summary>
        /// Gets or Sets AncillaryPath
        /// </summary>
        [DataMember(Name = "ancillary_path", EmitDefaultValue = false)]
        public string AncillaryPath { get; set; }

        /// <summary>
        /// Gets or Sets AncillaryPathReadOnly
        /// </summary>
        [DataMember(Name = "ancillary_path_read_only", EmitDefaultValue = true)]
        public bool AncillaryPathReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementsGroupDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  MembersPreview: ").Append(MembersPreview).Append("\n");
            sb.Append("  EffectivePermissions: ").Append(EffectivePermissions).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Ldap: ").Append(Ldap).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LdapDn: ").Append(LdapDn).Append("\n");
            sb.Append("  UnixGroupname: ").Append(UnixGroupname).Append("\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  AncillaryPath: ").Append(AncillaryPath).Append("\n");
            sb.Append("  AncillaryPathReadOnly: ").Append(AncillaryPathReadOnly).Append("\n");
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
            return this.Equals(input as ElementsGroupDetail);
        }

        /// <summary>
        /// Returns true if ElementsGroupDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementsGroupDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementsGroupDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.MembersPreview == input.MembersPreview ||
                    this.MembersPreview != null &&
                    input.MembersPreview != null &&
                    this.MembersPreview.SequenceEqual(input.MembersPreview)
                ) && 
                (
                    this.EffectivePermissions == input.EffectivePermissions ||
                    this.EffectivePermissions != null &&
                    input.EffectivePermissions != null &&
                    this.EffectivePermissions.SequenceEqual(input.EffectivePermissions)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Ldap == input.Ldap ||
                    (this.Ldap != null &&
                    this.Ldap.Equals(input.Ldap))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LdapDn == input.LdapDn ||
                    (this.LdapDn != null &&
                    this.LdapDn.Equals(input.LdapDn))
                ) && 
                (
                    this.UnixGroupname == input.UnixGroupname ||
                    (this.UnixGroupname != null &&
                    this.UnixGroupname.Equals(input.UnixGroupname))
                ) && 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.AncillaryPath == input.AncillaryPath ||
                    (this.AncillaryPath != null &&
                    this.AncillaryPath.Equals(input.AncillaryPath))
                ) && 
                (
                    this.AncillaryPathReadOnly == input.AncillaryPathReadOnly ||
                    this.AncillaryPathReadOnly.Equals(input.AncillaryPathReadOnly)
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.MembersPreview != null)
                    hashCode = hashCode * 59 + this.MembersPreview.GetHashCode();
                if (this.EffectivePermissions != null)
                    hashCode = hashCode * 59 + this.EffectivePermissions.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Ldap != null)
                    hashCode = hashCode * 59 + this.Ldap.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LdapDn != null)
                    hashCode = hashCode * 59 + this.LdapDn.GetHashCode();
                if (this.UnixGroupname != null)
                    hashCode = hashCode * 59 + this.UnixGroupname.GetHashCode();
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.AncillaryPath != null)
                    hashCode = hashCode * 59 + this.AncillaryPath.GetHashCode();
                hashCode = hashCode * 59 + this.AncillaryPathReadOnly.GetHashCode();
                return hashCode;
            }
        }

    }

}
