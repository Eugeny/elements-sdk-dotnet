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
    /// MediaFileBundleMini
    /// </summary>
    [DataContract(Name = "MediaFileBundleMini")]
    public partial class MediaFileBundleMini : IEquatable<MediaFileBundleMini>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFileBundleMini" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaFileBundleMini() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFileBundleMini" /> class.
        /// </summary>
        /// <param name="asset">asset (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="mainfile">mainfile.</param>
        public MediaFileBundleMini(int asset = default(int), string name = default(string), int location = default(int), MediaFileMini mainfile = default(MediaFileMini))
        {
            this.Asset = asset;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for MediaFileBundleMini and cannot be null");
            this.Location = location;
            this.Mainfile = mainfile;
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
        public int Asset { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = false)]
        public int Location { get; set; }

        /// <summary>
        /// Gets or Sets Mainfile
        /// </summary>
        [DataMember(Name = "mainfile", EmitDefaultValue = false)]
        public MediaFileMini Mainfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaFileBundleMini {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Mainfile: ").Append(Mainfile).Append("\n");
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
            return this.Equals(input as MediaFileBundleMini);
        }

        /// <summary>
        /// Returns true if MediaFileBundleMini instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaFileBundleMini to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaFileBundleMini input)
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
                    this.Asset.Equals(input.Asset)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location.Equals(input.Location)
                ) && 
                (
                    this.Mainfile == input.Mainfile ||
                    (this.Mainfile != null &&
                    this.Mainfile.Equals(input.Mainfile))
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
                hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Mainfile != null)
                    hashCode = hashCode * 59 + this.Mainfile.GetHashCode();
                return hashCode;
            }
        }

    }

}
