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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BaseAnimalInfo : IEquatable<BaseAnimalInfo>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public Id Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AgeIsEstimated
        /// </summary>
        [Required]
        [DataMember(Name="ageIsEstimated")]
        public bool? AgeIsEstimated { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age")]
        public string Age { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        
        public enum AdoptionStatus
        {
            /// <summary>
            /// Enum AdoptionPendingEnum for Adoption Pending
            /// </summary>
            
            AdoptionPendingEnum = Adoption Pending,
            /// <summary>
            /// Enum AvailableEnum for Available
            /// </summary>
            
            AvailableEnum = Available,
            /// <summary>
            /// Enum AvailablePendingSpayNeuterEnum for Available Pending Spay/Neuter
            /// </summary>
            
            AvailablePendingSpayNeuterEnum = Available Pending Spay/Neuter,
            /// <summary>
            /// Enum MedicalHoldEnum for Medical Hold
            /// </summary>
            
            MedicalHoldEnum = Medical Hold,
            /// <summary>
            /// Enum PendingIntakeTestingEnum for Pending Intake Testing
            /// </summary>
            
            PendingIntakeTestingEnum = Pending Intake Testing        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status")]
        public AdoptionStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Gender
        {
            /// <summary>
            /// Enum MaleEnum for Male
            /// </summary>
            [EnumMember(Value = "Male")]
            MaleEnum = 0,
            /// <summary>
            /// Enum FemaleEnum for Female
            /// </summary>
            [EnumMember(Value = "Female")]
            FemaleEnum = 1,
            /// <summary>
            /// Enum UndeterminedEnum for Undetermined
            /// </summary>
            [EnumMember(Value = "Undetermined")]
            UndeterminedEnum = 2        }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [Required]
        [DataMember(Name="gender")]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum Species
        {
            /// <summary>
            /// Enum DogEnum for Dog
            /// </summary>
            [EnumMember(Value = "Dog")]
            DogEnum = 0,
            /// <summary>
            /// Enum CatEnum for Cat
            /// </summary>
            [EnumMember(Value = "Cat")]
            CatEnum = 1        }

        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        [DataMember(Name="species")]
        public Species? Species { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name="bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes")]
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BaseAnimalInfo)obj);
        }

        /// <summary>
        /// Returns true if BaseAnimalInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseAnimalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseAnimalInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    AgeIsEstimated == other.AgeIsEstimated ||
                    AgeIsEstimated != null &&
                    AgeIsEstimated.Equals(other.AgeIsEstimated)
                ) && 
                (
                    Age == other.Age ||
                    Age != null &&
                    Age.Equals(other.Age)
                ) && 
                (
                    DateOfBirth == other.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Gender == other.Gender ||
                    Gender != null &&
                    Gender.Equals(other.Gender)
                ) && 
                (
                    Species == other.Species ||
                    Species != null &&
                    Species.Equals(other.Species)
                ) && 
                (
                    Bio == other.Bio ||
                    Bio != null &&
                    Bio.Equals(other.Bio)
                ) && 
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    Notes.SequenceEqual(other.Notes)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AgeIsEstimated != null)
                    hashCode = hashCode * 59 + AgeIsEstimated.GetHashCode();
                    if (Age != null)
                    hashCode = hashCode * 59 + Age.GetHashCode();
                    if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Gender != null)
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (Species != null)
                    hashCode = hashCode * 59 + Species.GetHashCode();
                    if (Bio != null)
                    hashCode = hashCode * 59 + Bio.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseAnimalInfo left, BaseAnimalInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseAnimalInfo left, BaseAnimalInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}