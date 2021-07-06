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
    /// ClickGalleryLink
    /// </summary>
    [DataContract(Name = "ClickGalleryLink")]
    public partial class ClickGalleryLink : IEquatable<ClickGalleryLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClickGalleryLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClickGalleryLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClickGalleryLink" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="email">email.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="galleryId">galleryId (required).</param>
        /// <param name="notifyOnUse">notifyOnUse (required).</param>
        /// <param name="viewsLeft">viewsLeft.</param>
        /// <param name="elementsUser">elementsUser.</param>
        /// <param name="secretKey">secretKey.</param>
        public ClickGalleryLink(int? id = default(int?), string email = default(string), DateTime? expiresAt = default(DateTime?), int galleryId = default(int), bool notifyOnUse = default(bool), int? viewsLeft = default(int?), ClickLinkUser elementsUser = default(ClickLinkUser), string secretKey = default(string))
        {
            this.GalleryId = galleryId;
            this.NotifyOnUse = notifyOnUse;
            this.Id = id;
            this.Email = email;
            this.ExpiresAt = expiresAt;
            this.ViewsLeft = viewsLeft;
            this.ElementsUser = elementsUser;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets GalleryId
        /// </summary>
        [DataMember(Name = "gallery_id", IsRequired = true, EmitDefaultValue = false)]
        public int GalleryId { get; set; }

        /// <summary>
        /// Gets or Sets NotifyOnUse
        /// </summary>
        [DataMember(Name = "notify_on_use", IsRequired = true, EmitDefaultValue = true)]
        public bool NotifyOnUse { get; set; }

        /// <summary>
        /// Gets or Sets ViewsLeft
        /// </summary>
        [DataMember(Name = "views_left", EmitDefaultValue = true)]
        public int? ViewsLeft { get; set; }

        /// <summary>
        /// Gets or Sets ElementsUser
        /// </summary>
        [DataMember(Name = "elements_user", EmitDefaultValue = false)]
        public ClickLinkUser ElementsUser { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secret_key", EmitDefaultValue = true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickGalleryLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  GalleryId: ").Append(GalleryId).Append("\n");
            sb.Append("  NotifyOnUse: ").Append(NotifyOnUse).Append("\n");
            sb.Append("  ViewsLeft: ").Append(ViewsLeft).Append("\n");
            sb.Append("  ElementsUser: ").Append(ElementsUser).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(input as ClickGalleryLink);
        }

        /// <summary>
        /// Returns true if ClickGalleryLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ClickGalleryLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickGalleryLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.GalleryId == input.GalleryId ||
                    this.GalleryId.Equals(input.GalleryId)
                ) && 
                (
                    this.NotifyOnUse == input.NotifyOnUse ||
                    this.NotifyOnUse.Equals(input.NotifyOnUse)
                ) && 
                (
                    this.ViewsLeft == input.ViewsLeft ||
                    (this.ViewsLeft != null &&
                    this.ViewsLeft.Equals(input.ViewsLeft))
                ) && 
                (
                    this.ElementsUser == input.ElementsUser ||
                    (this.ElementsUser != null &&
                    this.ElementsUser.Equals(input.ElementsUser))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                hashCode = hashCode * 59 + this.GalleryId.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyOnUse.GetHashCode();
                if (this.ViewsLeft != null)
                    hashCode = hashCode * 59 + this.ViewsLeft.GetHashCode();
                if (this.ElementsUser != null)
                    hashCode = hashCode * 59 + this.ElementsUser.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                return hashCode;
            }
        }

    }

}
