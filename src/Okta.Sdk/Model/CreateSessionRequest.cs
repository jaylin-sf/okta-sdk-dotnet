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
    /// CreateSessionRequest
    /// </summary>
    [DataContract(Name = "CreateSessionRequest")]
    
    public partial class CreateSessionRequest : IEquatable<CreateSessionRequest>
    {
        
        /// <summary>
        /// Gets or Sets SessionToken
        /// </summary>
        [DataMember(Name = "sessionToken", EmitDefaultValue = false)]
        public string SessionToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSessionRequest {\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
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
            return this.Equals(input as CreateSessionRequest);
        }

        /// <summary>
        /// Returns true if CreateSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SessionToken == input.SessionToken ||
                    (this.SessionToken != null &&
                    this.SessionToken.Equals(input.SessionToken))
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
                
                if (this.SessionToken != null)
                {
                    hashCode = (hashCode * 59) + this.SessionToken.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
