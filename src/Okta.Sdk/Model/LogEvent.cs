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
    /// LogEvent
    /// </summary>
    [DataContract(Name = "LogEvent")]
    
    public partial class LogEvent : IEquatable<LogEvent>
    {

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        
        public LogSeverity Severity { get; set; }
        
        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name = "actor", EmitDefaultValue = false)]
        public LogActor Actor { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationContext
        /// </summary>
        [DataMember(Name = "authenticationContext", EmitDefaultValue = false)]
        public LogAuthenticationContext AuthenticationContext { get; set; }

        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public LogClient _Client { get; set; }

        /// <summary>
        /// Gets or Sets DebugContext
        /// </summary>
        [DataMember(Name = "debugContext", EmitDefaultValue = false)]
        public LogDebugContext DebugContext { get; set; }

        /// <summary>
        /// Gets or Sets DisplayMessage
        /// </summary>
        [DataMember(Name = "displayMessage", EmitDefaultValue = false)]
        public string DisplayMessage { get; private set; }

        /// <summary>
        /// Returns false as DisplayMessage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayMessage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; private set; }

        /// <summary>
        /// Returns false as EventType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEventType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LegacyEventType
        /// </summary>
        [DataMember(Name = "legacyEventType", EmitDefaultValue = false)]
        public string LegacyEventType { get; private set; }

        /// <summary>
        /// Returns false as LegacyEventType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLegacyEventType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public LogOutcome Outcome { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name = "published", EmitDefaultValue = false)]
        public DateTimeOffset Published { get; private set; }

        /// <summary>
        /// Returns false as Published should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePublished()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public LogRequest Request { get; set; }

        /// <summary>
        /// Gets or Sets SecurityContext
        /// </summary>
        [DataMember(Name = "securityContext", EmitDefaultValue = false)]
        public LogSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public List<LogTarget> Target { get; private set; }

        /// <summary>
        /// Returns false as Target should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTarget()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public LogTransaction Transaction { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; private set; }

        /// <summary>
        /// Returns false as _Version should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerialize_Version()
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
            sb.Append("class LogEvent {\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  AuthenticationContext: ").Append(AuthenticationContext).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  DebugContext: ").Append(DebugContext).Append("\n");
            sb.Append("  DisplayMessage: ").Append(DisplayMessage).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  LegacyEventType: ").Append(LegacyEventType).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as LogEvent);
        }

        /// <summary>
        /// Returns true if LogEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of LogEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Actor == input.Actor ||
                    (this.Actor != null &&
                    this.Actor.Equals(input.Actor))
                ) && 
                (
                    this.AuthenticationContext == input.AuthenticationContext ||
                    (this.AuthenticationContext != null &&
                    this.AuthenticationContext.Equals(input.AuthenticationContext))
                ) && 
                (
                    this._Client == input._Client ||
                    (this._Client != null &&
                    this._Client.Equals(input._Client))
                ) && 
                (
                    this.DebugContext == input.DebugContext ||
                    (this.DebugContext != null &&
                    this.DebugContext.Equals(input.DebugContext))
                ) && 
                (
                    this.DisplayMessage == input.DisplayMessage ||
                    (this.DisplayMessage != null &&
                    this.DisplayMessage.Equals(input.DisplayMessage))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.LegacyEventType == input.LegacyEventType ||
                    (this.LegacyEventType != null &&
                    this.LegacyEventType.Equals(input.LegacyEventType))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.SecurityContext == input.SecurityContext ||
                    (this.SecurityContext != null &&
                    this.SecurityContext.Equals(input.SecurityContext))
                ) && 
                (
                    this.Severity == input.Severity ||
                    this.Severity.Equals(input.Severity)
                ) && 
                (
                    this.Target == input.Target ||
                    this.Target != null &&
                    input.Target != null &&
                    this.Target.SequenceEqual(input.Target)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                
                if (this.Actor != null)
                {
                    hashCode = (hashCode * 59) + this.Actor.GetHashCode();
                }
                if (this.AuthenticationContext != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationContext.GetHashCode();
                }
                if (this._Client != null)
                {
                    hashCode = (hashCode * 59) + this._Client.GetHashCode();
                }
                if (this.DebugContext != null)
                {
                    hashCode = (hashCode * 59) + this.DebugContext.GetHashCode();
                }
                if (this.DisplayMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayMessage.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.LegacyEventType != null)
                {
                    hashCode = (hashCode * 59) + this.LegacyEventType.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.Published != null)
                {
                    hashCode = (hashCode * 59) + this.Published.GetHashCode();
                }
                if (this.Request != null)
                {
                    hashCode = (hashCode * 59) + this.Request.GetHashCode();
                }
                if (this.SecurityContext != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityContext.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Severity.GetHashCode();
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
