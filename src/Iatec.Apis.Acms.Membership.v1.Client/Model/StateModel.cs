/* 
 * Acms Api
 *
 * The documentation for the ACMS Api
 *
 * OpenAPI spec version: 1.0.1
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Iatec.Apis.Acms.Membership.v1.Client.Model
{
    /// <summary>
    /// StateModel
    /// </summary>
    [DataContract]
    public partial class StateModel :  IEquatable<StateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Name">Name.</param>
        /// <param name="FormattedName">FormattedName.</param>
        /// <param name="Abbreviation">Abbreviation.</param>
        public StateModel(string Id = default(string), string Code = default(string), string Name = default(string), string FormattedName = default(string), string Abbreviation = default(string))
        {
            this.Id = Id;
            this.Code = Code;
            this.Name = Name;
            this.FormattedName = FormattedName;
            this.Abbreviation = Abbreviation;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets FormattedName
        /// </summary>
        [DataMember(Name="FormattedName", EmitDefaultValue=false)]
        public string FormattedName { get; set; }
        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name="Abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FormattedName: ").Append(FormattedName).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as StateModel);
        }

        /// <summary>
        /// Returns true if StateModel instances are equal
        /// </summary>
        /// <param name="other">Instance of StateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FormattedName == other.FormattedName ||
                    this.FormattedName != null &&
                    this.FormattedName.Equals(other.FormattedName)
                ) && 
                (
                    this.Abbreviation == other.Abbreviation ||
                    this.Abbreviation != null &&
                    this.Abbreviation.Equals(other.Abbreviation)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FormattedName != null)
                    hash = hash * 59 + this.FormattedName.GetHashCode();
                if (this.Abbreviation != null)
                    hash = hash * 59 + this.Abbreviation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
