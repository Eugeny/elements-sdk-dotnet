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
    /// NetStat
    /// </summary>
    [DataContract(Name = "NetStat")]
    public partial class NetStat : IEquatable<NetStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetStat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetStat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetStat" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="cRx">cRx (required).</param>
        /// <param name="cTx">cTx (required).</param>
        /// <param name="cRxErr">cRxErr (required).</param>
        /// <param name="cTxErr">cTxErr (required).</param>
        public NetStat(decimal time = default(decimal), decimal cRx = default(decimal), decimal cTx = default(decimal), decimal cRxErr = default(decimal), decimal cTxErr = default(decimal))
        {
            this.Time = time;
            this.CRx = cRx;
            this.CTx = cTx;
            this.CRxErr = cRxErr;
            this.CTxErr = cTxErr;
        }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = false)]
        public decimal Time { get; set; }

        /// <summary>
        /// Gets or Sets CRx
        /// </summary>
        [DataMember(Name = "c_rx", IsRequired = true, EmitDefaultValue = false)]
        public decimal CRx { get; set; }

        /// <summary>
        /// Gets or Sets CTx
        /// </summary>
        [DataMember(Name = "c_tx", IsRequired = true, EmitDefaultValue = false)]
        public decimal CTx { get; set; }

        /// <summary>
        /// Gets or Sets CRxErr
        /// </summary>
        [DataMember(Name = "c_rx_err", IsRequired = true, EmitDefaultValue = false)]
        public decimal CRxErr { get; set; }

        /// <summary>
        /// Gets or Sets CTxErr
        /// </summary>
        [DataMember(Name = "c_tx_err", IsRequired = true, EmitDefaultValue = false)]
        public decimal CTxErr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetStat {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  CRx: ").Append(CRx).Append("\n");
            sb.Append("  CTx: ").Append(CTx).Append("\n");
            sb.Append("  CRxErr: ").Append(CRxErr).Append("\n");
            sb.Append("  CTxErr: ").Append(CTxErr).Append("\n");
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
            return this.Equals(input as NetStat);
        }

        /// <summary>
        /// Returns true if NetStat instances are equal
        /// </summary>
        /// <param name="input">Instance of NetStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.CRx == input.CRx ||
                    this.CRx.Equals(input.CRx)
                ) && 
                (
                    this.CTx == input.CTx ||
                    this.CTx.Equals(input.CTx)
                ) && 
                (
                    this.CRxErr == input.CRxErr ||
                    this.CRxErr.Equals(input.CRxErr)
                ) && 
                (
                    this.CTxErr == input.CTxErr ||
                    this.CTxErr.Equals(input.CTxErr)
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.CRx.GetHashCode();
                hashCode = hashCode * 59 + this.CTx.GetHashCode();
                hashCode = hashCode * 59 + this.CRxErr.GetHashCode();
                hashCode = hashCode * 59 + this.CTxErr.GetHashCode();
                return hashCode;
            }
        }

    }

}
