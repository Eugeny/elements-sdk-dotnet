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
    /// MediaFileReference
    /// </summary>
    [DataContract(Name = "MediaFileReference")]
    public partial class MediaFileReference : IEquatable<MediaFileReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFileReference" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="volume">volume.</param>
        /// <param name="resolvedPermission">resolvedPermission.</param>
        /// <param name="root">root.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        public MediaFileReference(int id = default(int), VolumeMini volume = default(VolumeMini), MediaRootPermission resolvedPermission = default(MediaRootPermission), MediaRootMini root = default(MediaRootMini), ElementsUserMini modifiedBy = default(ElementsUserMini))
        {
            this.Id = id;
            this.Volume = volume;
            this.ResolvedPermission = resolvedPermission;
            this.Root = root;
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public VolumeMini Volume { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public Dictionary<string, string> Info { get; private set; }

        /// <summary>
        /// Returns false as Info should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInfo()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "custom_fields", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomFields { get; private set; }

        /// <summary>
        /// Returns false as CustomFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomFields()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ResolvedPermission
        /// </summary>
        [DataMember(Name = "resolved_permission", EmitDefaultValue = false)]
        public MediaRootPermission ResolvedPermission { get; set; }

        /// <summary>
        /// Gets or Sets ParentFile
        /// </summary>
        [DataMember(Name = "parent_file", EmitDefaultValue = false)]
        public Dictionary<string, string> ParentFile { get; private set; }

        /// <summary>
        /// Returns false as ParentFile should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentFile()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public MediaRootMini Root { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveCustomFields
        /// </summary>
        [DataMember(Name = "effective_custom_fields", EmitDefaultValue = false)]
        public Dictionary<string, string> EffectiveCustomFields { get; private set; }

        /// <summary>
        /// Returns false as EffectiveCustomFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEffectiveCustomFields()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modified_by", EmitDefaultValue = false)]
        public ElementsUserMini ModifiedBy { get; set; }

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
        /// Gets or Sets IsShared
        /// </summary>
        [DataMember(Name = "is_shared", EmitDefaultValue = true)]
        public bool IsShared { get; private set; }

        /// <summary>
        /// Returns false as IsShared should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsShared()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsExcluded
        /// </summary>
        [DataMember(Name = "is_excluded", EmitDefaultValue = true)]
        public bool IsExcluded { get; private set; }

        /// <summary>
        /// Returns false as IsExcluded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsExcluded()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsHardlink
        /// </summary>
        [DataMember(Name = "is_hardlink", EmitDefaultValue = true)]
        public bool IsHardlink { get; private set; }

        /// <summary>
        /// Returns false as IsHardlink should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsHardlink()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsBookmarked
        /// </summary>
        [DataMember(Name = "is_bookmarked", EmitDefaultValue = true)]
        public bool IsBookmarked { get; private set; }

        /// <summary>
        /// Returns false as IsBookmarked should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsBookmarked()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ChildCount
        /// </summary>
        [DataMember(Name = "child_count", EmitDefaultValue = false)]
        public int ChildCount { get; private set; }

        /// <summary>
        /// Returns false as ChildCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChildCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
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
        /// Gets or Sets Pathhash
        /// </summary>
        [DataMember(Name = "pathhash", EmitDefaultValue = false)]
        public string Pathhash { get; private set; }

        /// <summary>
        /// Returns false as Pathhash should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePathhash()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Ancestry
        /// </summary>
        [DataMember(Name = "ancestry", EmitDefaultValue = false)]
        public string Ancestry { get; private set; }

        /// <summary>
        /// Returns false as Ancestry should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAncestry()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsDir
        /// </summary>
        [DataMember(Name = "is_dir", EmitDefaultValue = true)]
        public bool IsDir { get; private set; }

        /// <summary>
        /// Returns false as IsDir should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDir()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalFiles
        /// </summary>
        [DataMember(Name = "total_files", EmitDefaultValue = true)]
        public int? TotalFiles { get; private set; }

        /// <summary>
        /// Returns false as TotalFiles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalFiles()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; private set; }

        /// <summary>
        /// Returns false as Size should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSize()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Mtime
        /// </summary>
        [DataMember(Name = "mtime", EmitDefaultValue = false)]
        public int Mtime { get; private set; }

        /// <summary>
        /// Returns false as Mtime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMtime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Present
        /// </summary>
        [DataMember(Name = "present", EmitDefaultValue = true)]
        public bool Present { get; private set; }

        /// <summary>
        /// Returns false as Present should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePresent()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NeedsRescan
        /// </summary>
        [DataMember(Name = "needs_rescan", EmitDefaultValue = true)]
        public bool NeedsRescan { get; private set; }

        /// <summary>
        /// Returns false as NeedsRescan should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNeedsRescan()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsShowroom
        /// </summary>
        [DataMember(Name = "is_showroom", EmitDefaultValue = true)]
        public bool IsShowroom { get; private set; }

        /// <summary>
        /// Returns false as IsShowroom should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsShowroom()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BundleIndex
        /// </summary>
        [DataMember(Name = "bundle_index", EmitDefaultValue = false)]
        public int BundleIndex { get; private set; }

        /// <summary>
        /// Returns false as BundleIndex should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBundleIndex()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; private set; }

        /// <summary>
        /// Returns false as Modified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModified()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public int Parent { get; private set; }

        /// <summary>
        /// Returns false as Parent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParent()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Bundle
        /// </summary>
        [DataMember(Name = "bundle", EmitDefaultValue = false)]
        public int Bundle { get; private set; }

        /// <summary>
        /// Returns false as Bundle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBundle()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BookmarkedBy
        /// </summary>
        [DataMember(Name = "bookmarked_by", EmitDefaultValue = false)]
        public List<int> BookmarkedBy { get; private set; }

        /// <summary>
        /// Returns false as BookmarkedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBookmarkedBy()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaFileReference {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ResolvedPermission: ").Append(ResolvedPermission).Append("\n");
            sb.Append("  ParentFile: ").Append(ParentFile).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  EffectiveCustomFields: ").Append(EffectiveCustomFields).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  IsShared: ").Append(IsShared).Append("\n");
            sb.Append("  IsExcluded: ").Append(IsExcluded).Append("\n");
            sb.Append("  IsHardlink: ").Append(IsHardlink).Append("\n");
            sb.Append("  IsBookmarked: ").Append(IsBookmarked).Append("\n");
            sb.Append("  ChildCount: ").Append(ChildCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Pathhash: ").Append(Pathhash).Append("\n");
            sb.Append("  Ancestry: ").Append(Ancestry).Append("\n");
            sb.Append("  IsDir: ").Append(IsDir).Append("\n");
            sb.Append("  TotalFiles: ").Append(TotalFiles).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Mtime: ").Append(Mtime).Append("\n");
            sb.Append("  Present: ").Append(Present).Append("\n");
            sb.Append("  NeedsRescan: ").Append(NeedsRescan).Append("\n");
            sb.Append("  IsShowroom: ").Append(IsShowroom).Append("\n");
            sb.Append("  BundleIndex: ").Append(BundleIndex).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Bundle: ").Append(Bundle).Append("\n");
            sb.Append("  BookmarkedBy: ").Append(BookmarkedBy).Append("\n");
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
            return this.Equals(input as MediaFileReference);
        }

        /// <summary>
        /// Returns true if MediaFileReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaFileReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaFileReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Info == input.Info ||
                    this.Info != null &&
                    input.Info != null &&
                    this.Info.SequenceEqual(input.Info)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.ResolvedPermission == input.ResolvedPermission ||
                    (this.ResolvedPermission != null &&
                    this.ResolvedPermission.Equals(input.ResolvedPermission))
                ) && 
                (
                    this.ParentFile == input.ParentFile ||
                    this.ParentFile != null &&
                    input.ParentFile != null &&
                    this.ParentFile.SequenceEqual(input.ParentFile)
                ) && 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.EffectiveCustomFields == input.EffectiveCustomFields ||
                    this.EffectiveCustomFields != null &&
                    input.EffectiveCustomFields != null &&
                    this.EffectiveCustomFields.SequenceEqual(input.EffectiveCustomFields)
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.IsShared == input.IsShared ||
                    this.IsShared.Equals(input.IsShared)
                ) && 
                (
                    this.IsExcluded == input.IsExcluded ||
                    this.IsExcluded.Equals(input.IsExcluded)
                ) && 
                (
                    this.IsHardlink == input.IsHardlink ||
                    this.IsHardlink.Equals(input.IsHardlink)
                ) && 
                (
                    this.IsBookmarked == input.IsBookmarked ||
                    this.IsBookmarked.Equals(input.IsBookmarked)
                ) && 
                (
                    this.ChildCount == input.ChildCount ||
                    this.ChildCount.Equals(input.ChildCount)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Pathhash == input.Pathhash ||
                    (this.Pathhash != null &&
                    this.Pathhash.Equals(input.Pathhash))
                ) && 
                (
                    this.Ancestry == input.Ancestry ||
                    (this.Ancestry != null &&
                    this.Ancestry.Equals(input.Ancestry))
                ) && 
                (
                    this.IsDir == input.IsDir ||
                    this.IsDir.Equals(input.IsDir)
                ) && 
                (
                    this.TotalFiles == input.TotalFiles ||
                    (this.TotalFiles != null &&
                    this.TotalFiles.Equals(input.TotalFiles))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Mtime == input.Mtime ||
                    this.Mtime.Equals(input.Mtime)
                ) && 
                (
                    this.Present == input.Present ||
                    this.Present.Equals(input.Present)
                ) && 
                (
                    this.NeedsRescan == input.NeedsRescan ||
                    this.NeedsRescan.Equals(input.NeedsRescan)
                ) && 
                (
                    this.IsShowroom == input.IsShowroom ||
                    this.IsShowroom.Equals(input.IsShowroom)
                ) && 
                (
                    this.BundleIndex == input.BundleIndex ||
                    this.BundleIndex.Equals(input.BundleIndex)
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Parent == input.Parent ||
                    this.Parent.Equals(input.Parent)
                ) && 
                (
                    this.Bundle == input.Bundle ||
                    this.Bundle.Equals(input.Bundle)
                ) && 
                (
                    this.BookmarkedBy == input.BookmarkedBy ||
                    this.BookmarkedBy != null &&
                    input.BookmarkedBy != null &&
                    this.BookmarkedBy.SequenceEqual(input.BookmarkedBy)
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
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.ResolvedPermission != null)
                    hashCode = hashCode * 59 + this.ResolvedPermission.GetHashCode();
                if (this.ParentFile != null)
                    hashCode = hashCode * 59 + this.ParentFile.GetHashCode();
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.EffectiveCustomFields != null)
                    hashCode = hashCode * 59 + this.EffectiveCustomFields.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                hashCode = hashCode * 59 + this.IsShared.GetHashCode();
                hashCode = hashCode * 59 + this.IsExcluded.GetHashCode();
                hashCode = hashCode * 59 + this.IsHardlink.GetHashCode();
                hashCode = hashCode * 59 + this.IsBookmarked.GetHashCode();
                hashCode = hashCode * 59 + this.ChildCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Pathhash != null)
                    hashCode = hashCode * 59 + this.Pathhash.GetHashCode();
                if (this.Ancestry != null)
                    hashCode = hashCode * 59 + this.Ancestry.GetHashCode();
                hashCode = hashCode * 59 + this.IsDir.GetHashCode();
                if (this.TotalFiles != null)
                    hashCode = hashCode * 59 + this.TotalFiles.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Mtime.GetHashCode();
                hashCode = hashCode * 59 + this.Present.GetHashCode();
                hashCode = hashCode * 59 + this.NeedsRescan.GetHashCode();
                hashCode = hashCode * 59 + this.IsShowroom.GetHashCode();
                hashCode = hashCode * 59 + this.BundleIndex.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                hashCode = hashCode * 59 + this.Parent.GetHashCode();
                hashCode = hashCode * 59 + this.Bundle.GetHashCode();
                if (this.BookmarkedBy != null)
                    hashCode = hashCode * 59 + this.BookmarkedBy.GetHashCode();
                return hashCode;
            }
        }

    }

}
