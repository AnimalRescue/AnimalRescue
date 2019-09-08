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
    public partial class Contact : IEquatable<Contact>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public Id Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses")]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Phones
        /// </summary>
        [DataMember(Name="phones")]
        public List<PhoneNumber> Phones { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails")]
        public List<EmailAddress> Emails { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets DriversLicense
        /// </summary>
        [DataMember(Name="driversLicense")]
        public string DriversLicense { get; set; }

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
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DriversLicense: ").Append(DriversLicense).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Contact)obj);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="other">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact other)
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
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    MiddleName == other.MiddleName ||
                    MiddleName != null &&
                    MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    Addresses == other.Addresses ||
                    Addresses != null &&
                    Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    Phones == other.Phones ||
                    Phones != null &&
                    Phones.SequenceEqual(other.Phones)
                ) && 
                (
                    Emails == other.Emails ||
                    Emails != null &&
                    Emails.SequenceEqual(other.Emails)
                ) && 
                (
                    DateOfBirth == other.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    DriversLicense == other.DriversLicense ||
                    DriversLicense != null &&
                    DriversLicense.Equals(other.DriversLicense)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (MiddleName != null)
                    hashCode = hashCode * 59 + MiddleName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (Addresses != null)
                    hashCode = hashCode * 59 + Addresses.GetHashCode();
                    if (Phones != null)
                    hashCode = hashCode * 59 + Phones.GetHashCode();
                    if (Emails != null)
                    hashCode = hashCode * 59 + Emails.GetHashCode();
                    if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                    if (DriversLicense != null)
                    hashCode = hashCode * 59 + DriversLicense.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Contact left, Contact right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Contact left, Contact right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}