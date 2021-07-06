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
    /// ElementsUserDetailPartialUpdate
    /// </summary>
    [DataContract(Name = "ElementsUserDetailPartialUpdate")]
    public partial class ElementsUserDetailPartialUpdate : IEquatable<ElementsUserDetailPartialUpdate>
    {
        /// <summary>
        /// Defines Language
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageEnum
        {
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 1,

            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 2,

            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 3,

            /// <summary>
            /// Enum Ru for value: ru
            /// </summary>
            [EnumMember(Value = "ru")]
            Ru = 4

        }


        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementsUserDetailPartialUpdate" /> class.
        /// </summary>
        /// <param name="allowChangingPassword">allowChangingPassword.</param>
        /// <param name="allowWanLogin">allowWanLogin.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="defaultPage">defaultPage.</param>
        /// <param name="email">email.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="ancillaryPathReadOnly">ancillaryPathReadOnly.</param>
        /// <param name="ancillaryPath">ancillaryPath.</param>
        /// <param name="fmBookmarks">fmBookmarks.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="gid">gid.</param>
        /// <param name="home">home.</param>
        /// <param name="isExternal">isExternal.</param>
        /// <param name="isCloud">isCloud.</param>
        /// <param name="isCloudDefault">isCloudDefault.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="language">language.</param>
        /// <param name="lastSeen">lastSeen.</param>
        /// <param name="ldap">ldap.</param>
        /// <param name="ldapDn">ldapDn.</param>
        /// <param name="passwordChangeRequired">passwordChangeRequired.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="shaperCeiling">shaperCeiling.</param>
        /// <param name="shaperRate">shaperRate.</param>
        /// <param name="totpEnabled">totpEnabled.</param>
        /// <param name="uid">uid.</param>
        /// <param name="unixUsername">unixUsername.</param>
        /// <param name="username">username.</param>
        /// <param name="groups">groups.</param>
        public ElementsUserDetailPartialUpdate(bool allowChangingPassword = default(bool), bool allowWanLogin = default(bool), string avatar = default(string), string defaultPage = default(string), string email = default(string), DateTime? expiry = default(DateTime?), bool ancillaryPathReadOnly = default(bool), string ancillaryPath = default(string), List<string> fmBookmarks = default(List<string>), string fullName = default(string), int? gid = default(int?), int? home = default(int?), bool isExternal = default(bool), bool isCloud = default(bool), bool isCloudDefault = default(bool), bool isEnabled = default(bool), LanguageEnum? language = default(LanguageEnum?), DateTime? lastSeen = default(DateTime?), LDAPServerReference ldap = default(LDAPServerReference), string ldapDn = default(string), bool passwordChangeRequired = default(bool), List<string> permissions = default(List<string>), int? shaperCeiling = default(int?), int? shaperRate = default(int?), bool totpEnabled = default(bool), int? uid = default(int?), string unixUsername = default(string), string username = default(string), List<int> groups = default(List<int>))
        {
            this.AllowChangingPassword = allowChangingPassword;
            this.AllowWanLogin = allowWanLogin;
            this.Avatar = avatar;
            this.DefaultPage = defaultPage;
            this.Email = email;
            this.Expiry = expiry;
            this.AncillaryPathReadOnly = ancillaryPathReadOnly;
            this.AncillaryPath = ancillaryPath;
            this.FmBookmarks = fmBookmarks;
            this.FullName = fullName;
            this.Gid = gid;
            this.Home = home;
            this.IsExternal = isExternal;
            this.IsCloud = isCloud;
            this.IsCloudDefault = isCloudDefault;
            this.IsEnabled = isEnabled;
            this.Language = language;
            this.LastSeen = lastSeen;
            this.Ldap = ldap;
            this.LdapDn = ldapDn;
            this.PasswordChangeRequired = passwordChangeRequired;
            this.Permissions = permissions;
            this.ShaperCeiling = shaperCeiling;
            this.ShaperRate = shaperRate;
            this.TotpEnabled = totpEnabled;
            this.Uid = uid;
            this.UnixUsername = unixUsername;
            this.Username = username;
            this.Groups = groups;
        }

        /// <summary>
        /// Gets or Sets AllowChangingPassword
        /// </summary>
        [DataMember(Name = "allow_changing_password", EmitDefaultValue = true)]
        public bool AllowChangingPassword { get; set; }

        /// <summary>
        /// Gets or Sets AllowWanLogin
        /// </summary>
        [DataMember(Name = "allow_wan_login", EmitDefaultValue = true)]
        public bool AllowWanLogin { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPage
        /// </summary>
        [DataMember(Name = "default_page", EmitDefaultValue = false)]
        public string DefaultPage { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Expiry
        /// </summary>
        [DataMember(Name = "expiry", EmitDefaultValue = true)]
        public DateTime? Expiry { get; set; }

        /// <summary>
        /// Gets or Sets AncillaryPathReadOnly
        /// </summary>
        [DataMember(Name = "ancillary_path_read_only", EmitDefaultValue = true)]
        public bool AncillaryPathReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets AncillaryPath
        /// </summary>
        [DataMember(Name = "ancillary_path", EmitDefaultValue = false)]
        public string AncillaryPath { get; set; }

        /// <summary>
        /// Gets or Sets FmBookmarks
        /// </summary>
        [DataMember(Name = "fm_bookmarks", EmitDefaultValue = false)]
        public List<string> FmBookmarks { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Gid
        /// </summary>
        [DataMember(Name = "gid", EmitDefaultValue = true)]
        public int? Gid { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = true)]
        public int? Home { get; set; }

        /// <summary>
        /// Gets or Sets IsExternal
        /// </summary>
        [DataMember(Name = "is_external", EmitDefaultValue = true)]
        public bool IsExternal { get; set; }

        /// <summary>
        /// Gets or Sets IsCloud
        /// </summary>
        [DataMember(Name = "is_cloud", EmitDefaultValue = true)]
        public bool IsCloud { get; set; }

        /// <summary>
        /// Gets or Sets IsCloudDefault
        /// </summary>
        [DataMember(Name = "is_cloud_default", EmitDefaultValue = true)]
        public bool IsCloudDefault { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "is_enabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LastSeen
        /// </summary>
        [DataMember(Name = "last_seen", EmitDefaultValue = true)]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Gets or Sets Ldap
        /// </summary>
        [DataMember(Name = "ldap", EmitDefaultValue = false)]
        public LDAPServerReference Ldap { get; set; }

        /// <summary>
        /// Gets or Sets LdapDn
        /// </summary>
        [DataMember(Name = "ldap_dn", EmitDefaultValue = true)]
        public string LdapDn { get; set; }

        /// <summary>
        /// Gets or Sets PasswordChangeRequired
        /// </summary>
        [DataMember(Name = "password_change_required", EmitDefaultValue = true)]
        public bool PasswordChangeRequired { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets ShaperCeiling
        /// </summary>
        [DataMember(Name = "shaper_ceiling", EmitDefaultValue = true)]
        public int? ShaperCeiling { get; set; }

        /// <summary>
        /// Gets or Sets ShaperRate
        /// </summary>
        [DataMember(Name = "shaper_rate", EmitDefaultValue = true)]
        public int? ShaperRate { get; set; }

        /// <summary>
        /// Gets or Sets TotpEnabled
        /// </summary>
        [DataMember(Name = "totp_enabled", EmitDefaultValue = true)]
        public bool TotpEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = true)]
        public int? Uid { get; set; }

        /// <summary>
        /// Gets or Sets UnixUsername
        /// </summary>
        [DataMember(Name = "unix_username", EmitDefaultValue = true)]
        public string UnixUsername { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<int> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementsUserDetailPartialUpdate {\n");
            sb.Append("  AllowChangingPassword: ").Append(AllowChangingPassword).Append("\n");
            sb.Append("  AllowWanLogin: ").Append(AllowWanLogin).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  DefaultPage: ").Append(DefaultPage).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  AncillaryPathReadOnly: ").Append(AncillaryPathReadOnly).Append("\n");
            sb.Append("  AncillaryPath: ").Append(AncillaryPath).Append("\n");
            sb.Append("  FmBookmarks: ").Append(FmBookmarks).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  IsExternal: ").Append(IsExternal).Append("\n");
            sb.Append("  IsCloud: ").Append(IsCloud).Append("\n");
            sb.Append("  IsCloudDefault: ").Append(IsCloudDefault).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  Ldap: ").Append(Ldap).Append("\n");
            sb.Append("  LdapDn: ").Append(LdapDn).Append("\n");
            sb.Append("  PasswordChangeRequired: ").Append(PasswordChangeRequired).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ShaperCeiling: ").Append(ShaperCeiling).Append("\n");
            sb.Append("  ShaperRate: ").Append(ShaperRate).Append("\n");
            sb.Append("  TotpEnabled: ").Append(TotpEnabled).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  UnixUsername: ").Append(UnixUsername).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as ElementsUserDetailPartialUpdate);
        }

        /// <summary>
        /// Returns true if ElementsUserDetailPartialUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementsUserDetailPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementsUserDetailPartialUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowChangingPassword == input.AllowChangingPassword ||
                    this.AllowChangingPassword.Equals(input.AllowChangingPassword)
                ) && 
                (
                    this.AllowWanLogin == input.AllowWanLogin ||
                    this.AllowWanLogin.Equals(input.AllowWanLogin)
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.DefaultPage == input.DefaultPage ||
                    (this.DefaultPage != null &&
                    this.DefaultPage.Equals(input.DefaultPage))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.AncillaryPathReadOnly == input.AncillaryPathReadOnly ||
                    this.AncillaryPathReadOnly.Equals(input.AncillaryPathReadOnly)
                ) && 
                (
                    this.AncillaryPath == input.AncillaryPath ||
                    (this.AncillaryPath != null &&
                    this.AncillaryPath.Equals(input.AncillaryPath))
                ) && 
                (
                    this.FmBookmarks == input.FmBookmarks ||
                    this.FmBookmarks != null &&
                    input.FmBookmarks != null &&
                    this.FmBookmarks.SequenceEqual(input.FmBookmarks)
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.Home == input.Home ||
                    (this.Home != null &&
                    this.Home.Equals(input.Home))
                ) && 
                (
                    this.IsExternal == input.IsExternal ||
                    this.IsExternal.Equals(input.IsExternal)
                ) && 
                (
                    this.IsCloud == input.IsCloud ||
                    this.IsCloud.Equals(input.IsCloud)
                ) && 
                (
                    this.IsCloudDefault == input.IsCloudDefault ||
                    this.IsCloudDefault.Equals(input.IsCloudDefault)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.Ldap == input.Ldap ||
                    (this.Ldap != null &&
                    this.Ldap.Equals(input.Ldap))
                ) && 
                (
                    this.LdapDn == input.LdapDn ||
                    (this.LdapDn != null &&
                    this.LdapDn.Equals(input.LdapDn))
                ) && 
                (
                    this.PasswordChangeRequired == input.PasswordChangeRequired ||
                    this.PasswordChangeRequired.Equals(input.PasswordChangeRequired)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.ShaperCeiling == input.ShaperCeiling ||
                    (this.ShaperCeiling != null &&
                    this.ShaperCeiling.Equals(input.ShaperCeiling))
                ) && 
                (
                    this.ShaperRate == input.ShaperRate ||
                    (this.ShaperRate != null &&
                    this.ShaperRate.Equals(input.ShaperRate))
                ) && 
                (
                    this.TotpEnabled == input.TotpEnabled ||
                    this.TotpEnabled.Equals(input.TotpEnabled)
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.UnixUsername == input.UnixUsername ||
                    (this.UnixUsername != null &&
                    this.UnixUsername.Equals(input.UnixUsername))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                hashCode = hashCode * 59 + this.AllowChangingPassword.GetHashCode();
                hashCode = hashCode * 59 + this.AllowWanLogin.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.DefaultPage != null)
                    hashCode = hashCode * 59 + this.DefaultPage.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                hashCode = hashCode * 59 + this.AncillaryPathReadOnly.GetHashCode();
                if (this.AncillaryPath != null)
                    hashCode = hashCode * 59 + this.AncillaryPath.GetHashCode();
                if (this.FmBookmarks != null)
                    hashCode = hashCode * 59 + this.FmBookmarks.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Gid != null)
                    hashCode = hashCode * 59 + this.Gid.GetHashCode();
                if (this.Home != null)
                    hashCode = hashCode * 59 + this.Home.GetHashCode();
                hashCode = hashCode * 59 + this.IsExternal.GetHashCode();
                hashCode = hashCode * 59 + this.IsCloud.GetHashCode();
                hashCode = hashCode * 59 + this.IsCloudDefault.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LastSeen != null)
                    hashCode = hashCode * 59 + this.LastSeen.GetHashCode();
                if (this.Ldap != null)
                    hashCode = hashCode * 59 + this.Ldap.GetHashCode();
                if (this.LdapDn != null)
                    hashCode = hashCode * 59 + this.LdapDn.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordChangeRequired.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.ShaperCeiling != null)
                    hashCode = hashCode * 59 + this.ShaperCeiling.GetHashCode();
                if (this.ShaperRate != null)
                    hashCode = hashCode * 59 + this.ShaperRate.GetHashCode();
                hashCode = hashCode * 59 + this.TotpEnabled.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.UnixUsername != null)
                    hashCode = hashCode * 59 + this.UnixUsername.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                return hashCode;
            }
        }

    }

}
