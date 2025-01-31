/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// Session
    /// </summary>
    [DataContract(Name = "Session")]
    
    public partial class Session : IEquatable<Session>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        
        public SessionStatus Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Amr
        /// </summary>
        [DataMember(Name = "amr", EmitDefaultValue = false)]
        public List<SessionAuthenticationMethod> Amr { get; private set; }

        /// <summary>
        /// Returns false as Amr should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmr()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public DateTimeOffset ExpiresAt { get; private set; }

        /// <summary>
        /// Returns false as ExpiresAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Idp
        /// </summary>
        [DataMember(Name = "idp", EmitDefaultValue = false)]
        public SessionIdentityProvider Idp { get; set; }

        /// <summary>
        /// Gets or Sets LastFactorVerification
        /// </summary>
        [DataMember(Name = "lastFactorVerification", EmitDefaultValue = false)]
        public DateTimeOffset LastFactorVerification { get; private set; }

        /// <summary>
        /// Returns false as LastFactorVerification should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastFactorVerification()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastPasswordVerification
        /// </summary>
        [DataMember(Name = "lastPasswordVerification", EmitDefaultValue = false)]
        public DateTimeOffset LastPasswordVerification { get; private set; }

        /// <summary>
        /// Returns false as LastPasswordVerification should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastPasswordVerification()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        public string Login { get; private set; }

        /// <summary>
        /// Returns false as Login should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogin()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; private set; }

        /// <summary>
        /// Returns false as UserId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Session {\n");
            sb.Append("  Amr: ").Append(Amr).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Idp: ").Append(Idp).Append("\n");
            sb.Append("  LastFactorVerification: ").Append(LastFactorVerification).Append("\n");
            sb.Append("  LastPasswordVerification: ").Append(LastPasswordVerification).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Session);
        }

        /// <summary>
        /// Returns true if Session instances are equal
        /// </summary>
        /// <param name="input">Instance of Session to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Session input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amr == input.Amr ||
                    this.Amr != null &&
                    input.Amr != null &&
                    this.Amr.SequenceEqual(input.Amr)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Idp == input.Idp ||
                    (this.Idp != null &&
                    this.Idp.Equals(input.Idp))
                ) && 
                (
                    this.LastFactorVerification == input.LastFactorVerification ||
                    (this.LastFactorVerification != null &&
                    this.LastFactorVerification.Equals(input.LastFactorVerification))
                ) && 
                (
                    this.LastPasswordVerification == input.LastPasswordVerification ||
                    (this.LastPasswordVerification != null &&
                    this.LastPasswordVerification.Equals(input.LastPasswordVerification))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                
                if (this.Amr != null)
                {
                    hashCode = (hashCode * 59) + this.Amr.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Idp != null)
                {
                    hashCode = (hashCode * 59) + this.Idp.GetHashCode();
                }
                if (this.LastFactorVerification != null)
                {
                    hashCode = (hashCode * 59) + this.LastFactorVerification.GetHashCode();
                }
                if (this.LastPasswordVerification != null)
                {
                    hashCode = (hashCode * 59) + this.LastPasswordVerification.GetHashCode();
                }
                if (this.Login != null)
                {
                    hashCode = (hashCode * 59) + this.Login.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
