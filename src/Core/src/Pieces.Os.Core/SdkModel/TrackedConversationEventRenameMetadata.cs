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
    /// This will give specific metadata need to determine what the rename was to/from.
    /// </summary>
    [DataContract(Name = "TrackedConversationEventRenameMetadata")]
    public partial class TrackedConversationEventRenameMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedConversationEventRenameMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackedConversationEventRenameMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedConversationEventRenameMetadata" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="previous">previous (required).</param>
        /// <param name="current">current (required).</param>
        public TrackedConversationEventRenameMetadata(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string previous = default(string), string current = default(string))
        {
            // to ensure "previous" is required (not null)
            if (previous == null)
            {
                throw new ArgumentNullException("previous is a required property for TrackedConversationEventRenameMetadata and cannot be null");
            }
            this.Previous = previous;
            // to ensure "current" is required (not null)
            if (current == null)
            {
                throw new ArgumentNullException("current is a required property for TrackedConversationEventRenameMetadata and cannot be null");
            }
            this.Current = current;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", IsRequired = true, EmitDefaultValue = true)]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name = "current", IsRequired = true, EmitDefaultValue = true)]
        public string Current { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedConversationEventRenameMetadata {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
