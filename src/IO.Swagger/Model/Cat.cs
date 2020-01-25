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
    /// Cat
    /// </summary>
    [DataContract]
        public partial class Cat :  IEquatable<Cat>
    {
        /// <summary>
        /// Gets or Sets Breed
        /// </summary>
        [DataMember(Name="breed", EmitDefaultValue=false)]
        public CatBreeds Breed { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public CatColors Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        /// <param name="baseInfo">baseInfo (required).</param>
        /// <param name="breed">breed (required).</param>
        /// <param name="color">color (required).</param>
        public Cat(BaseAnimalInfo baseInfo = default(BaseAnimalInfo), CatBreeds breed = default(CatBreeds), CatColors color = default(CatColors))
        {
            // to ensure "baseInfo" is required (not null)
            if (baseInfo == null)
            {
                throw new InvalidDataException("baseInfo is a required property for Cat and cannot be null");
            }
            else
            {
                this.BaseInfo = baseInfo;
            }
            // to ensure "breed" is required (not null)
            if (breed == null)
            {
                throw new InvalidDataException("breed is a required property for Cat and cannot be null");
            }
            else
            {
                this.Breed = breed;
            }
            // to ensure "color" is required (not null)
            if (color == null)
            {
                throw new InvalidDataException("color is a required property for Cat and cannot be null");
            }
            else
            {
                this.Color = color;
            }
        }
        
        /// <summary>
        /// Gets or Sets BaseInfo
        /// </summary>
        [DataMember(Name="baseInfo", EmitDefaultValue=false)]
        public BaseAnimalInfo BaseInfo { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cat {\n");
            sb.Append("  BaseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  Breed: ").Append(Breed).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(input as Cat);
        }

        /// <summary>
        /// Returns true if Cat instances are equal
        /// </summary>
        /// <param name="input">Instance of Cat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseInfo == input.BaseInfo ||
                    (this.BaseInfo != null &&
                    this.BaseInfo.Equals(input.BaseInfo))
                ) && 
                (
                    this.Breed == input.Breed ||
                    (this.Breed != null &&
                    this.Breed.Equals(input.Breed))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
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
                if (this.BaseInfo != null)
                    hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.Breed != null)
                    hashCode = hashCode * 59 + this.Breed.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                return hashCode;
            }
        }
    }
}
