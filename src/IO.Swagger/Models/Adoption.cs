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
    public partial class Adoption : IEquatable<Adoption>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id")]
        public Id Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Adoptees
        /// </summary>
        [DataMember(Name="adoptees")]
        public List<BaseAnimalInfo> Adoptees { get; set; }

        /// <summary>
        /// Gets or Sets Adoptor
        /// </summary>
        [DataMember(Name="adoptor")]
        public Contact Adoptor { get; set; }

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
            sb.Append("class Adoption {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Adoptees: ").Append(Adoptees).Append("\n");
            sb.Append("  Adoptor: ").Append(Adoptor).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Adoption)obj);
        }

        /// <summary>
        /// Returns true if Adoption instances are equal
        /// </summary>
        /// <param name="other">Instance of Adoption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adoption other)
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
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Adoptees == other.Adoptees ||
                    Adoptees != null &&
                    Adoptees.SequenceEqual(other.Adoptees)
                ) && 
                (
                    Adoptor == other.Adoptor ||
                    Adoptor != null &&
                    Adoptor.Equals(other.Adoptor)
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
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Adoptees != null)
                    hashCode = hashCode * 59 + Adoptees.GetHashCode();
                    if (Adoptor != null)
                    hashCode = hashCode * 59 + Adoptor.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Adoption left, Adoption right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Adoption left, Adoption right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}