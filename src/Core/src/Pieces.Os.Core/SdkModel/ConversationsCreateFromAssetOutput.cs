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
    /// This is the model for the output for the \&quot;/conversations/create/from_asset/{asset}\&quot; endpoints.
    /// </summary>
    [DataContract(Name = "ConversationsCreateFromAssetOutput")]
    public partial class ConversationsCreateFromAssetOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsCreateFromAssetOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationsCreateFromAssetOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsCreateFromAssetOutput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="conversation">conversation (required).</param>
        public ConversationsCreateFromAssetOutput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ReferencedConversation conversation = default(ReferencedConversation))
        {
            // to ensure "conversation" is required (not null)
            if (conversation == null)
            {
                throw new ArgumentNullException("conversation is a required property for ConversationsCreateFromAssetOutput and cannot be null");
            }
            this.Conversation = conversation;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedConversation Conversation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversationsCreateFromAssetOutput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
