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
    /// BaseAnimalInfo
    /// </summary>
    [DataContract]
        public partial class BaseAnimalInfo :  IEquatable<BaseAnimalInfo>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public AdoptionStatus Status { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public Gender Gender { get; set; }
        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        [DataMember(Name="species", EmitDefaultValue=false)]
        public Species? Species { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAnimalInfo" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name.</param>
        /// <param name="ageIsEstimated">ageIsEstimated (required).</param>
        /// <param name="age">age.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="status">status (required).</param>
        /// <param name="gender">gender (required).</param>
        /// <param name="species">species.</param>
        /// <param name="bio">bio.</param>
        /// <param name="notes">notes.</param>
        public BaseAnimalInfo(Id id = default(Id), string name = default(string), bool? ageIsEstimated = default(bool?), string age = default(string), DateTime? dateOfBirth = default(DateTime?), AdoptionStatus status = default(AdoptionStatus), Gender gender = default(Gender), Species? species = default(Species?), string bio = default(string), List<Note> notes = default(List<Note>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BaseAnimalInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "ageIsEstimated" is required (not null)
            if (ageIsEstimated == null)
            {
                throw new InvalidDataException("ageIsEstimated is a required property for BaseAnimalInfo and cannot be null");
            }
            else
            {
                this.AgeIsEstimated = ageIsEstimated;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for BaseAnimalInfo and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "gender" is required (not null)
            if (gender == null)
            {
                throw new InvalidDataException("gender is a required property for BaseAnimalInfo and cannot be null");
            }
            else
            {
                this.Gender = gender;
            }
            this.Name = name;
            this.Age = age;
            this.DateOfBirth = dateOfBirth;
            this.Species = species;
            this.Bio = bio;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Id Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AgeIsEstimated
        /// </summary>
        [DataMember(Name="ageIsEstimated", EmitDefaultValue=false)]
        public bool? AgeIsEstimated { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public string Age { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateOfBirth { get; set; }




        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio", EmitDefaultValue=false)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<Note> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseAnimalInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AgeIsEstimated: ").Append(AgeIsEstimated).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Species: ").Append(Species).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as BaseAnimalInfo);
        }

        /// <summary>
        /// Returns true if BaseAnimalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseAnimalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseAnimalInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AgeIsEstimated == input.AgeIsEstimated ||
                    (this.AgeIsEstimated != null &&
                    this.AgeIsEstimated.Equals(input.AgeIsEstimated))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Species == input.Species ||
                    (this.Species != null &&
                    this.Species.Equals(input.Species))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AgeIsEstimated != null)
                    hashCode = hashCode * 59 + this.AgeIsEstimated.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Species != null)
                    hashCode = hashCode * 59 + this.Species.GetHashCode();
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }
    }
}
