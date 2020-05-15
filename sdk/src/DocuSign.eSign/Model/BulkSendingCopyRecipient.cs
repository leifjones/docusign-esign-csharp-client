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
    /// BulkSendingCopyRecipient
    /// </summary>
    [DataContract]
    public partial class BulkSendingCopyRecipient :  IEquatable<BulkSendingCopyRecipient>, IValidatableObject
    {
        public BulkSendingCopyRecipient()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingCopyRecipient" /> class.
        /// </summary>
        /// <param name="AccessCode">If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required..</param>
        /// <param name="ClientUserId">Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. .</param>
        /// <param name="CustomFields">An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters..</param>
        /// <param name="DeliveryMethod">Reserved: For DocuSign use only..</param>
        /// <param name="Email">Email.</param>
        /// <param name="EmailNotification">EmailNotification.</param>
        /// <param name="EmbeddedRecipientStartURL">Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; .</param>
        /// <param name="FaxNumber">Reserved:.</param>
        /// <param name="IdCheckConfigurationName">Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node..</param>
        /// <param name="IdCheckInformationInput">IdCheckInformationInput.</param>
        /// <param name="IdentificationMethod">IdentificationMethod.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Note">Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters..</param>
        /// <param name="PhoneAuthentication">PhoneAuthentication.</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="RecipientSignatureProviders">RecipientSignatureProviders.</param>
        /// <param name="RoleName">Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients..</param>
        /// <param name="SmsAuthentication">SmsAuthentication.</param>
        /// <param name="SocialAuthentications"> Lists the social ID type that can be used for recipient authentication..</param>
        /// <param name="Tabs">Tabs.</param>
        public BulkSendingCopyRecipient(string AccessCode = default(string), string ClientUserId = default(string), List<string> CustomFields = default(List<string>), string DeliveryMethod = default(string), string Email = default(string), RecipientEmailNotification EmailNotification = default(RecipientEmailNotification), string EmbeddedRecipientStartURL = default(string), string FaxNumber = default(string), string IdCheckConfigurationName = default(string), IdCheckInformationInput IdCheckInformationInput = default(IdCheckInformationInput), string IdentificationMethod = default(string), string Name = default(string), string Note = default(string), RecipientPhoneAuthentication PhoneAuthentication = default(RecipientPhoneAuthentication), string RecipientId = default(string), List<RecipientSignatureProvider> RecipientSignatureProviders = default(List<RecipientSignatureProvider>), string RoleName = default(string), RecipientSMSAuthentication SmsAuthentication = default(RecipientSMSAuthentication), List<SocialAuthentication> SocialAuthentications = default(List<SocialAuthentication>), List<BulkSendingCopyTab> Tabs = default(List<BulkSendingCopyTab>))
        {
            this.AccessCode = AccessCode;
            this.ClientUserId = ClientUserId;
            this.CustomFields = CustomFields;
            this.DeliveryMethod = DeliveryMethod;
            this.Email = Email;
            this.EmailNotification = EmailNotification;
            this.EmbeddedRecipientStartURL = EmbeddedRecipientStartURL;
            this.FaxNumber = FaxNumber;
            this.IdCheckConfigurationName = IdCheckConfigurationName;
            this.IdCheckInformationInput = IdCheckInformationInput;
            this.IdentificationMethod = IdentificationMethod;
            this.Name = Name;
            this.Note = Note;
            this.PhoneAuthentication = PhoneAuthentication;
            this.RecipientId = RecipientId;
            this.RecipientSignatureProviders = RecipientSignatureProviders;
            this.RoleName = RoleName;
            this.SmsAuthentication = SmsAuthentication;
            this.SocialAuthentications = SocialAuthentications;
            this.Tabs = Tabs;
        }
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. 
        /// </summary>
        /// <value>Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. </value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
        /// <summary>
        /// An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.
        /// </summary>
        /// <value>An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<string> CustomFields { get; set; }
        /// <summary>
        /// Reserved: For DocuSign use only.
        /// </summary>
        /// <value>Reserved: For DocuSign use only.</value>
        [DataMember(Name="deliveryMethod", EmitDefaultValue=false)]
        public string DeliveryMethod { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailNotification
        /// </summary>
        [DataMember(Name="emailNotification", EmitDefaultValue=false)]
        public RecipientEmailNotification EmailNotification { get; set; }
        /// <summary>
        /// Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; 
        /// </summary>
        /// <value>Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender&#39;s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient&#39;s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60; </value>
        [DataMember(Name="embeddedRecipientStartURL", EmitDefaultValue=false)]
        public string EmbeddedRecipientStartURL { get; set; }
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="faxNumber", EmitDefaultValue=false)]
        public string FaxNumber { get; set; }
        /// <summary>
        /// Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node.
        /// </summary>
        /// <value>Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node.</value>
        [DataMember(Name="idCheckConfigurationName", EmitDefaultValue=false)]
        public string IdCheckConfigurationName { get; set; }
        /// <summary>
        /// Gets or Sets IdCheckInformationInput
        /// </summary>
        [DataMember(Name="idCheckInformationInput", EmitDefaultValue=false)]
        public IdCheckInformationInput IdCheckInformationInput { get; set; }
        /// <summary>
        /// Gets or Sets IdentificationMethod
        /// </summary>
        [DataMember(Name="identificationMethod", EmitDefaultValue=false)]
        public string IdentificationMethod { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters.
        /// </summary>
        /// <value>Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// Gets or Sets PhoneAuthentication
        /// </summary>
        [DataMember(Name="phoneAuthentication", EmitDefaultValue=false)]
        public RecipientPhoneAuthentication PhoneAuthentication { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// Gets or Sets RecipientSignatureProviders
        /// </summary>
        [DataMember(Name="recipientSignatureProviders", EmitDefaultValue=false)]
        public List<RecipientSignatureProvider> RecipientSignatureProviders { get; set; }
        /// <summary>
        /// Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.
        /// </summary>
        /// <value>Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
        /// <summary>
        /// Gets or Sets SmsAuthentication
        /// </summary>
        [DataMember(Name="smsAuthentication", EmitDefaultValue=false)]
        public RecipientSMSAuthentication SmsAuthentication { get; set; }
        /// <summary>
        ///  Lists the social ID type that can be used for recipient authentication.
        /// </summary>
        /// <value> Lists the social ID type that can be used for recipient authentication.</value>
        [DataMember(Name="socialAuthentications", EmitDefaultValue=false)]
        public List<SocialAuthentication> SocialAuthentications { get; set; }
        /// <summary>
        /// Gets or Sets Tabs
        /// </summary>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public List<BulkSendingCopyTab> Tabs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingCopyRecipient {\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  EmbeddedRecipientStartURL: ").Append(EmbeddedRecipientStartURL).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  IdCheckConfigurationName: ").Append(IdCheckConfigurationName).Append("\n");
            sb.Append("  IdCheckInformationInput: ").Append(IdCheckInformationInput).Append("\n");
            sb.Append("  IdentificationMethod: ").Append(IdentificationMethod).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PhoneAuthentication: ").Append(PhoneAuthentication).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  RecipientSignatureProviders: ").Append(RecipientSignatureProviders).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  SmsAuthentication: ").Append(SmsAuthentication).Append("\n");
            sb.Append("  SocialAuthentications: ").Append(SocialAuthentications).Append("\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
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
            return this.Equals(obj as BulkSendingCopyRecipient);
        }

        /// <summary>
        /// Returns true if BulkSendingCopyRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingCopyRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingCopyRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.DeliveryMethod == other.DeliveryMethod ||
                    this.DeliveryMethod != null &&
                    this.DeliveryMethod.Equals(other.DeliveryMethod)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailNotification == other.EmailNotification ||
                    this.EmailNotification != null &&
                    this.EmailNotification.Equals(other.EmailNotification)
                ) && 
                (
                    this.EmbeddedRecipientStartURL == other.EmbeddedRecipientStartURL ||
                    this.EmbeddedRecipientStartURL != null &&
                    this.EmbeddedRecipientStartURL.Equals(other.EmbeddedRecipientStartURL)
                ) && 
                (
                    this.FaxNumber == other.FaxNumber ||
                    this.FaxNumber != null &&
                    this.FaxNumber.Equals(other.FaxNumber)
                ) && 
                (
                    this.IdCheckConfigurationName == other.IdCheckConfigurationName ||
                    this.IdCheckConfigurationName != null &&
                    this.IdCheckConfigurationName.Equals(other.IdCheckConfigurationName)
                ) && 
                (
                    this.IdCheckInformationInput == other.IdCheckInformationInput ||
                    this.IdCheckInformationInput != null &&
                    this.IdCheckInformationInput.Equals(other.IdCheckInformationInput)
                ) && 
                (
                    this.IdentificationMethod == other.IdentificationMethod ||
                    this.IdentificationMethod != null &&
                    this.IdentificationMethod.Equals(other.IdentificationMethod)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.PhoneAuthentication == other.PhoneAuthentication ||
                    this.PhoneAuthentication != null &&
                    this.PhoneAuthentication.Equals(other.PhoneAuthentication)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.RecipientSignatureProviders == other.RecipientSignatureProviders ||
                    this.RecipientSignatureProviders != null &&
                    this.RecipientSignatureProviders.SequenceEqual(other.RecipientSignatureProviders)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.SmsAuthentication == other.SmsAuthentication ||
                    this.SmsAuthentication != null &&
                    this.SmsAuthentication.Equals(other.SmsAuthentication)
                ) && 
                (
                    this.SocialAuthentications == other.SocialAuthentications ||
                    this.SocialAuthentications != null &&
                    this.SocialAuthentications.SequenceEqual(other.SocialAuthentications)
                ) && 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.SequenceEqual(other.Tabs)
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
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                if (this.ClientUserId != null)
                    hash = hash * 59 + this.ClientUserId.GetHashCode();
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                if (this.DeliveryMethod != null)
                    hash = hash * 59 + this.DeliveryMethod.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailNotification != null)
                    hash = hash * 59 + this.EmailNotification.GetHashCode();
                if (this.EmbeddedRecipientStartURL != null)
                    hash = hash * 59 + this.EmbeddedRecipientStartURL.GetHashCode();
                if (this.FaxNumber != null)
                    hash = hash * 59 + this.FaxNumber.GetHashCode();
                if (this.IdCheckConfigurationName != null)
                    hash = hash * 59 + this.IdCheckConfigurationName.GetHashCode();
                if (this.IdCheckInformationInput != null)
                    hash = hash * 59 + this.IdCheckInformationInput.GetHashCode();
                if (this.IdentificationMethod != null)
                    hash = hash * 59 + this.IdentificationMethod.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.PhoneAuthentication != null)
                    hash = hash * 59 + this.PhoneAuthentication.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.RecipientSignatureProviders != null)
                    hash = hash * 59 + this.RecipientSignatureProviders.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                if (this.SmsAuthentication != null)
                    hash = hash * 59 + this.SmsAuthentication.GetHashCode();
                if (this.SocialAuthentications != null)
                    hash = hash * 59 + this.SocialAuthentications.GetHashCode();
                if (this.Tabs != null)
                    hash = hash * 59 + this.Tabs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
