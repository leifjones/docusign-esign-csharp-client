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
    /// PaymentGatewayAccountsInfo
    /// </summary>
    [DataContract]
    public partial class PaymentGatewayAccountsInfo :  IEquatable<PaymentGatewayAccountsInfo>, IValidatableObject
    {
        public PaymentGatewayAccountsInfo()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGatewayAccountsInfo" /> class.
        /// </summary>
        /// <param name="PaymentGatewayAccounts">PaymentGatewayAccounts.</param>
        public PaymentGatewayAccountsInfo(List<PaymentGatewayAccount> PaymentGatewayAccounts = default(List<PaymentGatewayAccount>))
        {
            this.PaymentGatewayAccounts = PaymentGatewayAccounts;
        }
        
        /// <summary>
        /// Gets or Sets PaymentGatewayAccounts
        /// </summary>
        [DataMember(Name="paymentGatewayAccounts", EmitDefaultValue=false)]
        public List<PaymentGatewayAccount> PaymentGatewayAccounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentGatewayAccountsInfo {\n");
            sb.Append("  PaymentGatewayAccounts: ").Append(PaymentGatewayAccounts).Append("\n");
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
            return this.Equals(obj as PaymentGatewayAccountsInfo);
        }

        /// <summary>
        /// Returns true if PaymentGatewayAccountsInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentGatewayAccountsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentGatewayAccountsInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentGatewayAccounts == other.PaymentGatewayAccounts ||
                    this.PaymentGatewayAccounts != null &&
                    this.PaymentGatewayAccounts.SequenceEqual(other.PaymentGatewayAccounts)
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
                if (this.PaymentGatewayAccounts != null)
                    hash = hash * 59 + this.PaymentGatewayAccounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
