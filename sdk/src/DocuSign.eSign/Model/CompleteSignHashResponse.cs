/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
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
    /// CompleteSignHashResponse
    /// </summary>
    [DataContract]
    public partial class CompleteSignHashResponse :  IEquatable<CompleteSignHashResponse>, IValidatableObject
    {
        public CompleteSignHashResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteSignHashResponse" /> class.
        /// </summary>
        /// <param name="Documents">Complex element contains the details on the documents in the envelope..</param>
        /// <param name="RedirectionUrl">RedirectionUrl.</param>
        /// <param name="RemainingSignatureRequests">RemainingSignatureRequests.</param>
        public CompleteSignHashResponse(List<SignHashDocument> Documents = default(List<SignHashDocument>), string RedirectionUrl = default(string), string RemainingSignatureRequests = default(string))
        {
            this.Documents = Documents;
            this.RedirectionUrl = RedirectionUrl;
            this.RemainingSignatureRequests = RemainingSignatureRequests;
        }
        
        /// <summary>
        /// Complex element contains the details on the documents in the envelope.
        /// </summary>
        /// <value>Complex element contains the details on the documents in the envelope.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<SignHashDocument> Documents { get; set; }
        /// <summary>
        /// Gets or Sets RedirectionUrl
        /// </summary>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; set; }
        /// <summary>
        /// Gets or Sets RemainingSignatureRequests
        /// </summary>
        [DataMember(Name="remainingSignatureRequests", EmitDefaultValue=false)]
        public string RemainingSignatureRequests { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteSignHashResponse {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  RedirectionUrl: ").Append(RedirectionUrl).Append("\n");
            sb.Append("  RemainingSignatureRequests: ").Append(RemainingSignatureRequests).Append("\n");
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
            return this.Equals(obj as CompleteSignHashResponse);
        }

        /// <summary>
        /// Returns true if CompleteSignHashResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompleteSignHashResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteSignHashResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    this.RedirectionUrl == other.RedirectionUrl ||
                    this.RedirectionUrl != null &&
                    this.RedirectionUrl.Equals(other.RedirectionUrl)
                ) && 
                (
                    this.RemainingSignatureRequests == other.RemainingSignatureRequests ||
                    this.RemainingSignatureRequests != null &&
                    this.RemainingSignatureRequests.Equals(other.RemainingSignatureRequests)
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
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                if (this.RedirectionUrl != null)
                    hash = hash * 59 + this.RedirectionUrl.GetHashCode();
                if (this.RemainingSignatureRequests != null)
                    hash = hash * 59 + this.RemainingSignatureRequests.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
