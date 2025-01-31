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
    /// ApplicationCredentialsSigning
    /// </summary>
    [DataContract(Name = "ApplicationCredentialsSigning")]
    
    public partial class ApplicationCredentialsSigning : IEquatable<ApplicationCredentialsSigning>
    {

        /// <summary>
        /// Gets or Sets Use
        /// </summary>
        [DataMember(Name = "use", EmitDefaultValue = false)]
        
        public ApplicationCredentialsSigningUse Use { get; set; }
        
        /// <summary>
        /// Gets or Sets Kid
        /// </summary>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets LastRotated
        /// </summary>
        [DataMember(Name = "lastRotated", EmitDefaultValue = false)]
        public DateTimeOffset LastRotated { get; private set; }

        /// <summary>
        /// Returns false as LastRotated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastRotated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NextRotation
        /// </summary>
        [DataMember(Name = "nextRotation", EmitDefaultValue = false)]
        public DateTimeOffset NextRotation { get; private set; }

        /// <summary>
        /// Returns false as NextRotation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextRotation()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RotationMode
        /// </summary>
        [DataMember(Name = "rotationMode", EmitDefaultValue = false)]
        public string RotationMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCredentialsSigning {\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  LastRotated: ").Append(LastRotated).Append("\n");
            sb.Append("  NextRotation: ").Append(NextRotation).Append("\n");
            sb.Append("  RotationMode: ").Append(RotationMode).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
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
            return this.Equals(input as ApplicationCredentialsSigning);
        }

        /// <summary>
        /// Returns true if ApplicationCredentialsSigning instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCredentialsSigning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCredentialsSigning input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.LastRotated == input.LastRotated ||
                    (this.LastRotated != null &&
                    this.LastRotated.Equals(input.LastRotated))
                ) && 
                (
                    this.NextRotation == input.NextRotation ||
                    (this.NextRotation != null &&
                    this.NextRotation.Equals(input.NextRotation))
                ) && 
                (
                    this.RotationMode == input.RotationMode ||
                    (this.RotationMode != null &&
                    this.RotationMode.Equals(input.RotationMode))
                ) && 
                (
                    this.Use == input.Use ||
                    this.Use.Equals(input.Use)
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
                
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                if (this.LastRotated != null)
                {
                    hashCode = (hashCode * 59) + this.LastRotated.GetHashCode();
                }
                if (this.NextRotation != null)
                {
                    hashCode = (hashCode * 59) + this.NextRotation.GetHashCode();
                }
                if (this.RotationMode != null)
                {
                    hashCode = (hashCode * 59) + this.RotationMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Use.GetHashCode();
                return hashCode;
            }
        }

    }

}
