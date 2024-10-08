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
    /// This will return a specific event for the WPE.  note: value is nullable here because we may want to pass in transferables:true/false
    /// </summary>
    [DataContract(Name = "WorkstreamPatternEngineVisionEvent")]
    public partial class WorkstreamPatternEngineVisionEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamPatternEngineVisionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkstreamPatternEngineVisionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamPatternEngineVisionEvent" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="source">source.</param>
        /// <param name="textual">textual.</param>
        public WorkstreamPatternEngineVisionEvent(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), GroupedTimestamp created = default(GroupedTimestamp), WorkstreamPatternEngineSource source = default(WorkstreamPatternEngineSource), WorkstreamPatternEngineVisionEventTextualValue textual = default(WorkstreamPatternEngineVisionEventTextualValue))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for WorkstreamPatternEngineVisionEvent and cannot be null");
            }
            this.Id = id;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for WorkstreamPatternEngineVisionEvent and cannot be null");
            }
            this.Created = created;
            this.Schema = schema;
            this.Source = source;
            this.Textual = textual;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public WorkstreamPatternEngineSource Source { get; set; }

        /// <summary>
        /// Gets or Sets Textual
        /// </summary>
        [DataMember(Name = "textual", EmitDefaultValue = false)]
        public WorkstreamPatternEngineVisionEventTextualValue Textual { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkstreamPatternEngineVisionEvent {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Textual: ").Append(Textual).Append("\n");
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
