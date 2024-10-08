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
    /// This model is specifically for QGPT Conversation pipelines, the model is used to group conversational prompts for instance a conversation around generating code.  here are some use cases- 1. contextualized_code_generation- This is for users that want to have conversations around generating code, when there is provided context. 2. generalized_code- This is for users that want to have conversations without context around code. 3. contextualized_code- This is for users that want to have conversation around code with Context. 4. contextualized_code_workstream: this is for the users that want to use context as well as WPE information in their chat (we wiil prioritize WPE infomration, but also support other info as well)
    /// </summary>
    [DataContract(Name = "QGPTConversationPipeline")]
    public partial class QGPTConversationPipeline : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTConversationPipeline" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="contextualizedCodeGeneration">contextualizedCodeGeneration.</param>
        /// <param name="generalizedCodeDialog">generalizedCodeDialog.</param>
        /// <param name="contextualizedCodeDialog">contextualizedCodeDialog.</param>
        /// <param name="contextualizedCodeWorkstreamDialog">contextualizedCodeWorkstreamDialog.</param>
        public QGPTConversationPipeline(EmbeddedModelSchema schema = default(EmbeddedModelSchema), QGPTConversationPipelineForContextualizedCodeGeneration contextualizedCodeGeneration = default(QGPTConversationPipelineForContextualizedCodeGeneration), QGPTConversationPipelineForGeneralizedCodeDialog generalizedCodeDialog = default(QGPTConversationPipelineForGeneralizedCodeDialog), QGPTConversationPipelineForContextualizedCodeDialog contextualizedCodeDialog = default(QGPTConversationPipelineForContextualizedCodeDialog), QGPTConversationPipelineForContextualizedCodeWorkstreamDialog contextualizedCodeWorkstreamDialog = default(QGPTConversationPipelineForContextualizedCodeWorkstreamDialog))
        {
            this.Schema = schema;
            this.ContextualizedCodeGeneration = contextualizedCodeGeneration;
            this.GeneralizedCodeDialog = generalizedCodeDialog;
            this.ContextualizedCodeDialog = contextualizedCodeDialog;
            this.ContextualizedCodeWorkstreamDialog = contextualizedCodeWorkstreamDialog;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets ContextualizedCodeGeneration
        /// </summary>
        [DataMember(Name = "contextualized_code_generation", EmitDefaultValue = false)]
        public QGPTConversationPipelineForContextualizedCodeGeneration ContextualizedCodeGeneration { get; set; }

        /// <summary>
        /// Gets or Sets GeneralizedCodeDialog
        /// </summary>
        [DataMember(Name = "generalized_code_dialog", EmitDefaultValue = false)]
        public QGPTConversationPipelineForGeneralizedCodeDialog GeneralizedCodeDialog { get; set; }

        /// <summary>
        /// Gets or Sets ContextualizedCodeDialog
        /// </summary>
        [DataMember(Name = "contextualized_code_dialog", EmitDefaultValue = false)]
        public QGPTConversationPipelineForContextualizedCodeDialog ContextualizedCodeDialog { get; set; }

        /// <summary>
        /// Gets or Sets ContextualizedCodeWorkstreamDialog
        /// </summary>
        [DataMember(Name = "contextualized_code_workstream_dialog", EmitDefaultValue = false)]
        public QGPTConversationPipelineForContextualizedCodeWorkstreamDialog ContextualizedCodeWorkstreamDialog { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTConversationPipeline {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  ContextualizedCodeGeneration: ").Append(ContextualizedCodeGeneration).Append("\n");
            sb.Append("  GeneralizedCodeDialog: ").Append(GeneralizedCodeDialog).Append("\n");
            sb.Append("  ContextualizedCodeDialog: ").Append(ContextualizedCodeDialog).Append("\n");
            sb.Append("  ContextualizedCodeWorkstreamDialog: ").Append(ContextualizedCodeWorkstreamDialog).Append("\n");
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
