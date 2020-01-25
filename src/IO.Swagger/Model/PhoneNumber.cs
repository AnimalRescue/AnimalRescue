/* 
 * AnimalRescue API
 *
 * API for OSS AnimalRescue
 *
 * OpenAPI spec version: 1.0.0-oas3
 * Contact: jlgartee@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PhoneNumber
    /// </summary>
    [DataContract]
        public partial class PhoneNumber :  IEquatable<PhoneNumber>
    {
        /// <summary>
        /// Defines Location
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LocationEnum
        {
            /// <summary>
            /// Enum Home for value: Home
            /// </summary>
            [EnumMember(Value = "Home")]
            Home = 0,
            /// <summary>
            /// Enum Work for value: Work
            /// </summary>
            [EnumMember(Value = "Work")]
            Work = 1,
            /// <summary>
            /// Enum Mobile for value: Mobile
            /// </summary>
            [EnumMember(Value = "Mobile")]
            Mobile = 2,
            /// <summary>
            /// Enum Fax for value: Fax
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax = 3,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 4        }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public LocationEnum Location { get; set; }
        /// <summary>
        /// Defines NumberType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NumberTypeEnum
        {
            /// <summary>
            /// Enum Primary for value: Primary
            /// </summary>
            [EnumMember(Value = "Primary")]
            Primary = 0,
            /// <summary>
            /// Enum Alternate for value: Alternate
            /// </summary>
            [EnumMember(Value = "Alternate")]
            Alternate = 1,
            /// <summary>
            /// Enum Notification for value: Notification
            /// </summary>
            [EnumMember(Value = "Notification")]
            Notification = 2        }
        /// <summary>
        /// Gets or Sets NumberType
        /// </summary>
        [DataMember(Name="numberType", EmitDefaultValue=false)]
        public NumberTypeEnum NumberType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="number">number (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="numberType">numberType (required).</param>
        public PhoneNumber(int? number = default(int?), LocationEnum location = default(LocationEnum), NumberTypeEnum numberType = default(NumberTypeEnum))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for PhoneNumber and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for PhoneNumber and cannot be null");
            }
            else
            {
                this.Location = location;
            }
            // to ensure "numberType" is required (not null)
            if (numberType == null)
            {
                throw new InvalidDataException("numberType is a required property for PhoneNumber and cannot be null");
            }
            else
            {
                this.NumberType = numberType;
            }
        }
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  NumberType: ").Append(NumberType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PhoneNumber);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.NumberType == input.NumberType ||
                    (this.NumberType != null &&
                    this.NumberType.Equals(input.NumberType))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.NumberType != null)
                    hashCode = hashCode * 59 + this.NumberType.GetHashCode();
                return hashCode;
            }
        }
    }
}
