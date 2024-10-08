/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// A Context that is returned from almost all calls to the ContextAPI
    /// </summary>
    [DataContract(Name = "Context")]
    public partial class Context : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Context() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="os">This is th UUID of the OS that this context is currently connected to. This attempts to be the same as Segment&#39;s anonmyousId feild. It is attempted to be set at initial installation at Pieces/.identity/.os (required).</param>
        /// <param name="application">application (required).</param>
        /// <param name="health">health (required).</param>
        /// <param name="user">user.</param>
        public Context(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string os = default(string), Application application = default(Application), Health health = default(Health), UserProfile user = default(UserProfile))
        {
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new ArgumentNullException("os is a required property for Context and cannot be null");
            }
            this.Os = os;
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for Context and cannot be null");
            }
            this.Application = application;
            // to ensure "health" is required (not null)
            if (health == null)
            {
                throw new ArgumentNullException("health is a required property for Context and cannot be null");
            }
            this.Health = health;
            this.Schema = schema;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is th UUID of the OS that this context is currently connected to. This attempts to be the same as Segment&#39;s anonmyousId feild. It is attempted to be set at initial installation at Pieces/.identity/.os
        /// </summary>
        /// <value>This is th UUID of the OS that this context is currently connected to. This attempts to be the same as Segment&#39;s anonmyousId feild. It is attempted to be set at initial installation at Pieces/.identity/.os</value>
        [DataMember(Name = "os", IsRequired = true, EmitDefaultValue = true)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public Application Application { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name = "health", IsRequired = true, EmitDefaultValue = true)]
        public Health Health { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserProfile User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Context {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}
