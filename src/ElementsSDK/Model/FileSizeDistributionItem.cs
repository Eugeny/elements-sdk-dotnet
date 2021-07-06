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
    /// FileSizeDistributionItem
    /// </summary>
    [DataContract(Name = "FileSizeDistributionItem")]
    public partial class FileSizeDistributionItem : IEquatable<FileSizeDistributionItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSizeDistributionItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileSizeDistributionItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSizeDistributionItem" /> class.
        /// </summary>
        /// <param name="min">min (required).</param>
        /// <param name="max">max (required).</param>
        /// <param name="count">count (required).</param>
        /// <param name="percent">percent (required).</param>
        /// <param name="average">average (required).</param>
        /// <param name="total">total (required).</param>
        public FileSizeDistributionItem(int min = default(int), int max = default(int), int count = default(int), int percent = default(int), int average = default(int), int total = default(int))
        {
            this.Min = min;
            this.Max = max;
            this.Count = count;
            this.Percent = percent;
            this.Average = average;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", IsRequired = true, EmitDefaultValue = false)]
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", IsRequired = true, EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name = "percent", IsRequired = true, EmitDefaultValue = false)]
        public int Percent { get; set; }

        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name = "average", IsRequired = true, EmitDefaultValue = false)]
        public int Average { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSizeDistributionItem {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as FileSizeDistributionItem);
        }

        /// <summary>
        /// Returns true if FileSizeDistributionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSizeDistributionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSizeDistributionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.Average == input.Average ||
                    this.Average.Equals(input.Average)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                hashCode = hashCode * 59 + this.Min.GetHashCode();
                hashCode = hashCode * 59 + this.Max.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.Percent.GetHashCode();
                hashCode = hashCode * 59 + this.Average.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }

    }

}
