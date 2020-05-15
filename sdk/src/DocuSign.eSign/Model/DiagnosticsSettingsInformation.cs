/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DiagnosticsSettingsInformation
    /// </summary>
    [DataContract]
    public partial class DiagnosticsSettingsInformation :  IEquatable<DiagnosticsSettingsInformation>, IValidatableObject
    {
        public DiagnosticsSettingsInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsSettingsInformation" /> class.
        /// </summary>
        /// <param name="ApiRequestLogging"> When set to **true**, enables API request logging for the user. .</param>
        /// <param name="ApiRequestLogMaxEntries">Specifies the maximum number of API requests to log..</param>
        /// <param name="ApiRequestLogRemainingEntries">Indicates the remaining number of API requests that can be logged..</param>
        public DiagnosticsSettingsInformation(string ApiRequestLogging = default(string), string ApiRequestLogMaxEntries = default(string), string ApiRequestLogRemainingEntries = default(string))
        {
            this.ApiRequestLogging = ApiRequestLogging;
            this.ApiRequestLogMaxEntries = ApiRequestLogMaxEntries;
            this.ApiRequestLogRemainingEntries = ApiRequestLogRemainingEntries;
        }
        
        /// <summary>
        ///  When set to **true**, enables API request logging for the user. 
        /// </summary>
        /// <value> When set to **true**, enables API request logging for the user. </value>
        [DataMember(Name="apiRequestLogging", EmitDefaultValue=false)]
        public string ApiRequestLogging { get; set; }
        /// <summary>
        /// Specifies the maximum number of API requests to log.
        /// </summary>
        /// <value>Specifies the maximum number of API requests to log.</value>
        [DataMember(Name="apiRequestLogMaxEntries", EmitDefaultValue=false)]
        public string ApiRequestLogMaxEntries { get; set; }
        /// <summary>
        /// Indicates the remaining number of API requests that can be logged.
        /// </summary>
        /// <value>Indicates the remaining number of API requests that can be logged.</value>
        [DataMember(Name="apiRequestLogRemainingEntries", EmitDefaultValue=false)]
        public string ApiRequestLogRemainingEntries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosticsSettingsInformation {\n");
            sb.Append("  ApiRequestLogging: ").Append(ApiRequestLogging).Append("\n");
            sb.Append("  ApiRequestLogMaxEntries: ").Append(ApiRequestLogMaxEntries).Append("\n");
            sb.Append("  ApiRequestLogRemainingEntries: ").Append(ApiRequestLogRemainingEntries).Append("\n");
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
            return this.Equals(obj as DiagnosticsSettingsInformation);
        }

        /// <summary>
        /// Returns true if DiagnosticsSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of DiagnosticsSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticsSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiRequestLogging == other.ApiRequestLogging ||
                    this.ApiRequestLogging != null &&
                    this.ApiRequestLogging.Equals(other.ApiRequestLogging)
                ) && 
                (
                    this.ApiRequestLogMaxEntries == other.ApiRequestLogMaxEntries ||
                    this.ApiRequestLogMaxEntries != null &&
                    this.ApiRequestLogMaxEntries.Equals(other.ApiRequestLogMaxEntries)
                ) && 
                (
                    this.ApiRequestLogRemainingEntries == other.ApiRequestLogRemainingEntries ||
                    this.ApiRequestLogRemainingEntries != null &&
                    this.ApiRequestLogRemainingEntries.Equals(other.ApiRequestLogRemainingEntries)
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
                if (this.ApiRequestLogging != null)
                    hash = hash * 59 + this.ApiRequestLogging.GetHashCode();
                if (this.ApiRequestLogMaxEntries != null)
                    hash = hash * 59 + this.ApiRequestLogMaxEntries.GetHashCode();
                if (this.ApiRequestLogRemainingEntries != null)
                    hash = hash * 59 + this.ApiRequestLogRemainingEntries.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
