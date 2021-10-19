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
    /// MediaRootMini
    /// </summary>
    [DataContract(Name = "MediaRootMini")]
    public partial class MediaRootMini : IEquatable<MediaRootMini>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRootMini" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaRootMini() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRootMini" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="volume">volume (required).</param>
        /// <param name="prefetchThumbnailStrips">prefetchThumbnailStrips.</param>
        public MediaRootMini(string name = default(string), List<CustomFieldReference> customFields = default(List<CustomFieldReference>), VolumeMiniReference volume = default(VolumeMiniReference), bool prefetchThumbnailStrips = default(bool))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for MediaRootMini and cannot be null");
            // to ensure "volume" is required (not null)
            this.Volume = volume ?? throw new ArgumentNullException("volume is a required property for MediaRootMini and cannot be null");
            this.CustomFields = customFields;
            this.PrefetchThumbnailStrips = prefetchThumbnailStrips;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FullPath
        /// </summary>
        [DataMember(Name = "full_path", EmitDefaultValue = false)]
        public string FullPath { get; private set; }

        /// <summary>
        /// Returns false as FullPath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFullPath()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public List<CustomFieldReference> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = false)]
        public VolumeMiniReference Volume { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; private set; }

        /// <summary>
        /// Returns false as Path should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePath()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PrefetchThumbnailStrips
        /// </summary>
        [DataMember(Name = "prefetch_thumbnail_strips", EmitDefaultValue = true)]
        public bool PrefetchThumbnailStrips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaRootMini {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  PrefetchThumbnailStrips: ").Append(PrefetchThumbnailStrips).Append("\n");
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
            return this.Equals(input as MediaRootMini);
        }

        /// <summary>
        /// Returns true if MediaRootMini instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaRootMini to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaRootMini input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.PrefetchThumbnailStrips == input.PrefetchThumbnailStrips ||
                    this.PrefetchThumbnailStrips.Equals(input.PrefetchThumbnailStrips)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                hashCode = hashCode * 59 + this.PrefetchThumbnailStrips.GetHashCode();
                return hashCode;
            }
        }

    }

}
