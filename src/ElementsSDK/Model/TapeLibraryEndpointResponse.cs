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
    /// TapeLibraryEndpointResponse
    /// </summary>
    [DataContract(Name = "TapeLibraryEndpointResponse")]
    public partial class TapeLibraryEndpointResponse : IEquatable<TapeLibraryEndpointResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TapeLibraryEndpointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TapeLibraryEndpointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TapeLibraryEndpointResponse" /> class.
        /// </summary>
        /// <param name="drives">drives (required).</param>
        /// <param name="mailbox">mailbox (required).</param>
        /// <param name="slots">slots (required).</param>
        public TapeLibraryEndpointResponse(List<TapeLibrarySlot> drives = default(List<TapeLibrarySlot>), List<TapeLibrarySlot> mailbox = default(List<TapeLibrarySlot>), List<TapeLibrarySlot> slots = default(List<TapeLibrarySlot>))
        {
            // to ensure "drives" is required (not null)
            this.Drives = drives ?? throw new ArgumentNullException("drives is a required property for TapeLibraryEndpointResponse and cannot be null");
            // to ensure "mailbox" is required (not null)
            this.Mailbox = mailbox ?? throw new ArgumentNullException("mailbox is a required property for TapeLibraryEndpointResponse and cannot be null");
            // to ensure "slots" is required (not null)
            this.Slots = slots ?? throw new ArgumentNullException("slots is a required property for TapeLibraryEndpointResponse and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Drives
        /// </summary>
        [DataMember(Name = "drives", IsRequired = true, EmitDefaultValue = false)]
        public List<TapeLibrarySlot> Drives { get; set; }

        /// <summary>
        /// Gets or Sets Mailbox
        /// </summary>
        [DataMember(Name = "mailbox", IsRequired = true, EmitDefaultValue = false)]
        public List<TapeLibrarySlot> Mailbox { get; set; }

        /// <summary>
        /// Gets or Sets Slots
        /// </summary>
        [DataMember(Name = "slots", IsRequired = true, EmitDefaultValue = false)]
        public List<TapeLibrarySlot> Slots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TapeLibraryEndpointResponse {\n");
            sb.Append("  Drives: ").Append(Drives).Append("\n");
            sb.Append("  Mailbox: ").Append(Mailbox).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(input as TapeLibraryEndpointResponse);
        }

        /// <summary>
        /// Returns true if TapeLibraryEndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TapeLibraryEndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TapeLibraryEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Drives == input.Drives ||
                    this.Drives != null &&
                    input.Drives != null &&
                    this.Drives.SequenceEqual(input.Drives)
                ) && 
                (
                    this.Mailbox == input.Mailbox ||
                    this.Mailbox != null &&
                    input.Mailbox != null &&
                    this.Mailbox.SequenceEqual(input.Mailbox)
                ) && 
                (
                    this.Slots == input.Slots ||
                    this.Slots != null &&
                    input.Slots != null &&
                    this.Slots.SequenceEqual(input.Slots)
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
                if (this.Drives != null)
                    hashCode = hashCode * 59 + this.Drives.GetHashCode();
                if (this.Mailbox != null)
                    hashCode = hashCode * 59 + this.Mailbox.GetHashCode();
                if (this.Slots != null)
                    hashCode = hashCode * 59 + this.Slots.GetHashCode();
                return hashCode;
            }
        }

    }

}
