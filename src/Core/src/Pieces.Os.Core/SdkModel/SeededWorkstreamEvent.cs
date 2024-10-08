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
    /// This is a precreated version of a WorkstreamEvent event, this will be used ingested into PiecesOS and PiecesOS will do all the magic to transform this into relevant data show in the workstream feed.
    /// </summary>
    [DataContract(Name = "SeededWorkstreamEvent")]
    public partial class SeededWorkstreamEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededWorkstreamEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamEvent" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="score">score.</param>
        /// <param name="application">application (required).</param>
        /// <param name="trigger">trigger (required).</param>
        /// <param name="context">context.</param>
        /// <param name="summary">summary.</param>
        /// <param name="internalIdentifier">This is used to override the event identifier, if this was an event that was originally in the internal events collection..</param>
        public SeededWorkstreamEvent(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Score score = default(Score), Application application = default(Application), WorkstreamEventTrigger trigger = default(WorkstreamEventTrigger), WorkstreamEventContext context = default(WorkstreamEventContext), ReferencedWorkstreamSummary summary = default(ReferencedWorkstreamSummary), string internalIdentifier = default(string))
        {
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for SeededWorkstreamEvent and cannot be null");
            }
            this.Application = application;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for SeededWorkstreamEvent and cannot be null");
            }
            this.Trigger = trigger;
            this.Schema = schema;
            this.Score = score;
            this.Context = context;
            this.Summary = summary;
            this.InternalIdentifier = internalIdentifier;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public Application Application { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public WorkstreamEventTrigger Trigger { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public WorkstreamEventContext Context { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public ReferencedWorkstreamSummary Summary { get; set; }

        /// <summary>
        /// This is used to override the event identifier, if this was an event that was originally in the internal events collection.
        /// </summary>
        /// <value>This is used to override the event identifier, if this was an event that was originally in the internal events collection.</value>
        [DataMember(Name = "internal_identifier", EmitDefaultValue = false)]
        public string InternalIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededWorkstreamEvent {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  InternalIdentifier: ").Append(InternalIdentifier).Append("\n");
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
