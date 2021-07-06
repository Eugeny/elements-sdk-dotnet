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
    /// MediaRootPermissionAccessOptions
    /// </summary>
    [DataContract(Name = "MediaRootPermissionAccessOptions")]
    public partial class MediaRootPermissionAccessOptions : IEquatable<MediaRootPermissionAccessOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRootPermissionAccessOptions" /> class.
        /// </summary>
        /// <param name="showTags">showTags.</param>
        /// <param name="showComments">showComments.</param>
        /// <param name="showLocations">showLocations.</param>
        /// <param name="showCustomFields">showCustomFields.</param>
        /// <param name="showRatings">showRatings.</param>
        /// <param name="showSubclips">showSubclips.</param>
        /// <param name="showAiMetadata">showAiMetadata.</param>
        /// <param name="showMarkers">showMarkers.</param>
        /// <param name="allowCreate">allowCreate.</param>
        /// <param name="allowWriteFs">allowWriteFs.</param>
        /// <param name="allowWriteDb">allowWriteDb.</param>
        /// <param name="allowProxyDownload">allowProxyDownload.</param>
        /// <param name="allowOriginalDownload">allowOriginalDownload.</param>
        /// <param name="allowUpload">allowUpload.</param>
        /// <param name="allowSharing">allowSharing.</param>
        /// <param name="allowDeleteFs">allowDeleteFs.</param>
        /// <param name="allowDeleteDb">allowDeleteDb.</param>
        public MediaRootPermissionAccessOptions(bool showTags = default(bool), bool showComments = default(bool), bool showLocations = default(bool), bool showCustomFields = default(bool), bool showRatings = default(bool), bool showSubclips = default(bool), bool showAiMetadata = default(bool), bool showMarkers = default(bool), bool allowCreate = default(bool), bool allowWriteFs = default(bool), bool allowWriteDb = default(bool), bool allowProxyDownload = default(bool), bool allowOriginalDownload = default(bool), bool allowUpload = default(bool), bool allowSharing = default(bool), bool allowDeleteFs = default(bool), bool allowDeleteDb = default(bool))
        {
            this.ShowTags = showTags;
            this.ShowComments = showComments;
            this.ShowLocations = showLocations;
            this.ShowCustomFields = showCustomFields;
            this.ShowRatings = showRatings;
            this.ShowSubclips = showSubclips;
            this.ShowAiMetadata = showAiMetadata;
            this.ShowMarkers = showMarkers;
            this.AllowCreate = allowCreate;
            this.AllowWriteFs = allowWriteFs;
            this.AllowWriteDb = allowWriteDb;
            this.AllowProxyDownload = allowProxyDownload;
            this.AllowOriginalDownload = allowOriginalDownload;
            this.AllowUpload = allowUpload;
            this.AllowSharing = allowSharing;
            this.AllowDeleteFs = allowDeleteFs;
            this.AllowDeleteDb = allowDeleteDb;
        }

        /// <summary>
        /// Gets or Sets ShowTags
        /// </summary>
        [DataMember(Name = "show_tags", EmitDefaultValue = true)]
        public bool ShowTags { get; set; }

        /// <summary>
        /// Gets or Sets ShowComments
        /// </summary>
        [DataMember(Name = "show_comments", EmitDefaultValue = true)]
        public bool ShowComments { get; set; }

        /// <summary>
        /// Gets or Sets ShowLocations
        /// </summary>
        [DataMember(Name = "show_locations", EmitDefaultValue = true)]
        public bool ShowLocations { get; set; }

        /// <summary>
        /// Gets or Sets ShowCustomFields
        /// </summary>
        [DataMember(Name = "show_custom_fields", EmitDefaultValue = true)]
        public bool ShowCustomFields { get; set; }

        /// <summary>
        /// Gets or Sets ShowRatings
        /// </summary>
        [DataMember(Name = "show_ratings", EmitDefaultValue = true)]
        public bool ShowRatings { get; set; }

        /// <summary>
        /// Gets or Sets ShowSubclips
        /// </summary>
        [DataMember(Name = "show_subclips", EmitDefaultValue = true)]
        public bool ShowSubclips { get; set; }

        /// <summary>
        /// Gets or Sets ShowAiMetadata
        /// </summary>
        [DataMember(Name = "show_ai_metadata", EmitDefaultValue = true)]
        public bool ShowAiMetadata { get; set; }

        /// <summary>
        /// Gets or Sets ShowMarkers
        /// </summary>
        [DataMember(Name = "show_markers", EmitDefaultValue = true)]
        public bool ShowMarkers { get; set; }

        /// <summary>
        /// Gets or Sets AllowCreate
        /// </summary>
        [DataMember(Name = "allow_create", EmitDefaultValue = true)]
        public bool AllowCreate { get; set; }

        /// <summary>
        /// Gets or Sets AllowWriteFs
        /// </summary>
        [DataMember(Name = "allow_write_fs", EmitDefaultValue = true)]
        public bool AllowWriteFs { get; set; }

        /// <summary>
        /// Gets or Sets AllowWriteDb
        /// </summary>
        [DataMember(Name = "allow_write_db", EmitDefaultValue = true)]
        public bool AllowWriteDb { get; set; }

        /// <summary>
        /// Gets or Sets AllowProxyDownload
        /// </summary>
        [DataMember(Name = "allow_proxy_download", EmitDefaultValue = true)]
        public bool AllowProxyDownload { get; set; }

        /// <summary>
        /// Gets or Sets AllowOriginalDownload
        /// </summary>
        [DataMember(Name = "allow_original_download", EmitDefaultValue = true)]
        public bool AllowOriginalDownload { get; set; }

        /// <summary>
        /// Gets or Sets AllowUpload
        /// </summary>
        [DataMember(Name = "allow_upload", EmitDefaultValue = true)]
        public bool AllowUpload { get; set; }

        /// <summary>
        /// Gets or Sets AllowSharing
        /// </summary>
        [DataMember(Name = "allow_sharing", EmitDefaultValue = true)]
        public bool AllowSharing { get; set; }

        /// <summary>
        /// Gets or Sets AllowDeleteFs
        /// </summary>
        [DataMember(Name = "allow_delete_fs", EmitDefaultValue = true)]
        public bool AllowDeleteFs { get; set; }

        /// <summary>
        /// Gets or Sets AllowDeleteDb
        /// </summary>
        [DataMember(Name = "allow_delete_db", EmitDefaultValue = true)]
        public bool AllowDeleteDb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaRootPermissionAccessOptions {\n");
            sb.Append("  ShowTags: ").Append(ShowTags).Append("\n");
            sb.Append("  ShowComments: ").Append(ShowComments).Append("\n");
            sb.Append("  ShowLocations: ").Append(ShowLocations).Append("\n");
            sb.Append("  ShowCustomFields: ").Append(ShowCustomFields).Append("\n");
            sb.Append("  ShowRatings: ").Append(ShowRatings).Append("\n");
            sb.Append("  ShowSubclips: ").Append(ShowSubclips).Append("\n");
            sb.Append("  ShowAiMetadata: ").Append(ShowAiMetadata).Append("\n");
            sb.Append("  ShowMarkers: ").Append(ShowMarkers).Append("\n");
            sb.Append("  AllowCreate: ").Append(AllowCreate).Append("\n");
            sb.Append("  AllowWriteFs: ").Append(AllowWriteFs).Append("\n");
            sb.Append("  AllowWriteDb: ").Append(AllowWriteDb).Append("\n");
            sb.Append("  AllowProxyDownload: ").Append(AllowProxyDownload).Append("\n");
            sb.Append("  AllowOriginalDownload: ").Append(AllowOriginalDownload).Append("\n");
            sb.Append("  AllowUpload: ").Append(AllowUpload).Append("\n");
            sb.Append("  AllowSharing: ").Append(AllowSharing).Append("\n");
            sb.Append("  AllowDeleteFs: ").Append(AllowDeleteFs).Append("\n");
            sb.Append("  AllowDeleteDb: ").Append(AllowDeleteDb).Append("\n");
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
            return this.Equals(input as MediaRootPermissionAccessOptions);
        }

        /// <summary>
        /// Returns true if MediaRootPermissionAccessOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaRootPermissionAccessOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaRootPermissionAccessOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShowTags == input.ShowTags ||
                    this.ShowTags.Equals(input.ShowTags)
                ) && 
                (
                    this.ShowComments == input.ShowComments ||
                    this.ShowComments.Equals(input.ShowComments)
                ) && 
                (
                    this.ShowLocations == input.ShowLocations ||
                    this.ShowLocations.Equals(input.ShowLocations)
                ) && 
                (
                    this.ShowCustomFields == input.ShowCustomFields ||
                    this.ShowCustomFields.Equals(input.ShowCustomFields)
                ) && 
                (
                    this.ShowRatings == input.ShowRatings ||
                    this.ShowRatings.Equals(input.ShowRatings)
                ) && 
                (
                    this.ShowSubclips == input.ShowSubclips ||
                    this.ShowSubclips.Equals(input.ShowSubclips)
                ) && 
                (
                    this.ShowAiMetadata == input.ShowAiMetadata ||
                    this.ShowAiMetadata.Equals(input.ShowAiMetadata)
                ) && 
                (
                    this.ShowMarkers == input.ShowMarkers ||
                    this.ShowMarkers.Equals(input.ShowMarkers)
                ) && 
                (
                    this.AllowCreate == input.AllowCreate ||
                    this.AllowCreate.Equals(input.AllowCreate)
                ) && 
                (
                    this.AllowWriteFs == input.AllowWriteFs ||
                    this.AllowWriteFs.Equals(input.AllowWriteFs)
                ) && 
                (
                    this.AllowWriteDb == input.AllowWriteDb ||
                    this.AllowWriteDb.Equals(input.AllowWriteDb)
                ) && 
                (
                    this.AllowProxyDownload == input.AllowProxyDownload ||
                    this.AllowProxyDownload.Equals(input.AllowProxyDownload)
                ) && 
                (
                    this.AllowOriginalDownload == input.AllowOriginalDownload ||
                    this.AllowOriginalDownload.Equals(input.AllowOriginalDownload)
                ) && 
                (
                    this.AllowUpload == input.AllowUpload ||
                    this.AllowUpload.Equals(input.AllowUpload)
                ) && 
                (
                    this.AllowSharing == input.AllowSharing ||
                    this.AllowSharing.Equals(input.AllowSharing)
                ) && 
                (
                    this.AllowDeleteFs == input.AllowDeleteFs ||
                    this.AllowDeleteFs.Equals(input.AllowDeleteFs)
                ) && 
                (
                    this.AllowDeleteDb == input.AllowDeleteDb ||
                    this.AllowDeleteDb.Equals(input.AllowDeleteDb)
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
                hashCode = hashCode * 59 + this.ShowTags.GetHashCode();
                hashCode = hashCode * 59 + this.ShowComments.GetHashCode();
                hashCode = hashCode * 59 + this.ShowLocations.GetHashCode();
                hashCode = hashCode * 59 + this.ShowCustomFields.GetHashCode();
                hashCode = hashCode * 59 + this.ShowRatings.GetHashCode();
                hashCode = hashCode * 59 + this.ShowSubclips.GetHashCode();
                hashCode = hashCode * 59 + this.ShowAiMetadata.GetHashCode();
                hashCode = hashCode * 59 + this.ShowMarkers.GetHashCode();
                hashCode = hashCode * 59 + this.AllowCreate.GetHashCode();
                hashCode = hashCode * 59 + this.AllowWriteFs.GetHashCode();
                hashCode = hashCode * 59 + this.AllowWriteDb.GetHashCode();
                hashCode = hashCode * 59 + this.AllowProxyDownload.GetHashCode();
                hashCode = hashCode * 59 + this.AllowOriginalDownload.GetHashCode();
                hashCode = hashCode * 59 + this.AllowUpload.GetHashCode();
                hashCode = hashCode * 59 + this.AllowSharing.GetHashCode();
                hashCode = hashCode * 59 + this.AllowDeleteFs.GetHashCode();
                hashCode = hashCode * 59 + this.AllowDeleteDb.GetHashCode();
                return hashCode;
            }
        }

    }

}
