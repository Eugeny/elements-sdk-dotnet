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
    /// StorageNode
    /// </summary>
    [DataContract(Name = "StorageNode")]
    public partial class StorageNode : IEquatable<StorageNode>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines Ipmi
        /// </summary>
        public enum IpmiEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }


        /// <summary>
        /// Gets or Sets Ipmi
        /// </summary>
        [DataMember(Name = "ipmi", EmitDefaultValue = false)]
        public IpmiEnum? Ipmi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageNode" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="address">For communication between nodes only.</param>
        /// <param name="addressOverride">Enforces mounting from a specific address/hostname instead of the available interfaces.</param>
        /// <param name="backend">backend.</param>
        /// <param name="type">type.</param>
        /// <param name="ipmi">ipmi.</param>
        /// <param name="status">status.</param>
        public StorageNode(string name = default(string), string address = default(string), string addressOverride = default(string), Backend backend = default(Backend), TypeEnum? type = default(TypeEnum?), IpmiEnum? ipmi = default(IpmiEnum?), StorageNodeStatus status = default(StorageNodeStatus))
        {
            this.Name = name;
            this.Address = address;
            this.AddressOverride = addressOverride;
            this.Backend = backend;
            this.Type = type;
            this.Ipmi = ipmi;
            this.Status = status;
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
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// For communication between nodes only
        /// </summary>
        /// <value>For communication between nodes only</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Enforces mounting from a specific address/hostname instead of the available interfaces
        /// </summary>
        /// <value>Enforces mounting from a specific address/hostname instead of the available interfaces</value>
        [DataMember(Name = "address_override", EmitDefaultValue = true)]
        public string AddressOverride { get; set; }

        /// <summary>
        /// Gets or Sets Backend
        /// </summary>
        [DataMember(Name = "backend", EmitDefaultValue = false)]
        public Backend Backend { get; set; }

        /// <summary>
        /// Gets or Sets Interfaces
        /// </summary>
        [DataMember(Name = "interfaces", EmitDefaultValue = false)]
        public List<Interface> Interfaces { get; private set; }

        /// <summary>
        /// Returns false as Interfaces should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInterfaces()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StorageNodeStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets IsLogAggregator
        /// </summary>
        [DataMember(Name = "is_log_aggregator", EmitDefaultValue = true)]
        public bool IsLogAggregator { get; private set; }

        /// <summary>
        /// Returns false as IsLogAggregator should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsLogAggregator()
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
            sb.Append("class StorageNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressOverride: ").Append(AddressOverride).Append("\n");
            sb.Append("  Backend: ").Append(Backend).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Ipmi: ").Append(Ipmi).Append("\n");
            sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsLogAggregator: ").Append(IsLogAggregator).Append("\n");
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
            return this.Equals(input as StorageNode);
        }

        /// <summary>
        /// Returns true if StorageNode instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageNode input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressOverride == input.AddressOverride ||
                    (this.AddressOverride != null &&
                    this.AddressOverride.Equals(input.AddressOverride))
                ) && 
                (
                    this.Backend == input.Backend ||
                    (this.Backend != null &&
                    this.Backend.Equals(input.Backend))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Ipmi == input.Ipmi ||
                    this.Ipmi.Equals(input.Ipmi)
                ) && 
                (
                    this.Interfaces == input.Interfaces ||
                    this.Interfaces != null &&
                    input.Interfaces != null &&
                    this.Interfaces.SequenceEqual(input.Interfaces)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsLogAggregator == input.IsLogAggregator ||
                    this.IsLogAggregator.Equals(input.IsLogAggregator)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressOverride != null)
                    hashCode = hashCode * 59 + this.AddressOverride.GetHashCode();
                if (this.Backend != null)
                    hashCode = hashCode * 59 + this.Backend.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Ipmi.GetHashCode();
                if (this.Interfaces != null)
                    hashCode = hashCode * 59 + this.Interfaces.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IsLogAggregator.GetHashCode();
                return hashCode;
            }
        }

    }

}
