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
    /// Subclip
    /// </summary>
    [DataContract(Name = "Subclip")]
    public partial class Subclip : IEquatable<Subclip>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subclip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subclip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subclip" /> class.
        /// </summary>
        /// <param name="asset">asset (required).</param>
        /// <param name="rendered">rendered.</param>
        /// <param name="shared">shared.</param>
        /// <param name="name">name.</param>
        /// <param name="tIn">tIn (required).</param>
        /// <param name="tOut">tOut (required).</param>
        /// <param name="root">root (required).</param>
        public Subclip(AssetMiniReference asset = default(AssetMiniReference), AssetMiniReference rendered = default(AssetMiniReference), bool shared = default(bool), string name = default(string), decimal tIn = default(decimal), decimal tOut = default(decimal), MediaRootMiniReference root = default(MediaRootMiniReference))
        {
            // to ensure "asset" is required (not null)
            this.Asset = asset ?? throw new ArgumentNullException("asset is a required property for Subclip and cannot be null");
            this.TIn = tIn;
            this.TOut = tOut;
            // to ensure "root" is required (not null)
            this.Root = root ?? throw new ArgumentNullException("root is a required property for Subclip and cannot be null");
            this.Rendered = rendered;
            this.Shared = shared;
            this.Name = name;
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
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = false)]
        public AssetMiniReference Asset { get; set; }

        /// <summary>
        /// Gets or Sets Rendered
        /// </summary>
        [DataMember(Name = "rendered", EmitDefaultValue = false)]
        public AssetMiniReference Rendered { get; set; }

        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TIn
        /// </summary>
        [DataMember(Name = "t_in", IsRequired = true, EmitDefaultValue = false)]
        public decimal TIn { get; set; }

        /// <summary>
        /// Gets or Sets TOut
        /// </summary>
        [DataMember(Name = "t_out", IsRequired = true, EmitDefaultValue = false)]
        public decimal TOut { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public int User { get; private set; }

        /// <summary>
        /// Returns false as User should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUser()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", IsRequired = true, EmitDefaultValue = false)]
        public MediaRootMiniReference Root { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subclip {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Rendered: ").Append(Rendered).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TIn: ").Append(TIn).Append("\n");
            sb.Append("  TOut: ").Append(TOut).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
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
            return this.Equals(input as Subclip);
        }

        /// <summary>
        /// Returns true if Subclip instances are equal
        /// </summary>
        /// <param name="input">Instance of Subclip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subclip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
                ) && 
                (
                    this.Rendered == input.Rendered ||
                    (this.Rendered != null &&
                    this.Rendered.Equals(input.Rendered))
                ) && 
                (
                    this.Shared == input.Shared ||
                    this.Shared.Equals(input.Shared)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TIn == input.TIn ||
                    this.TIn.Equals(input.TIn)
                ) && 
                (
                    this.TOut == input.TOut ||
                    this.TOut.Equals(input.TOut)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
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
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.Rendered != null)
                    hashCode = hashCode * 59 + this.Rendered.GetHashCode();
                hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.TIn.GetHashCode();
                hashCode = hashCode * 59 + this.TOut.GetHashCode();
                hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                return hashCode;
            }
        }

    }

}
