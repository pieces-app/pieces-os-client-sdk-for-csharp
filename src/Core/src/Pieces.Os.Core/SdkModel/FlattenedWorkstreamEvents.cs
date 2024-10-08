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
    /// This is a plural (DAG Safe) version of a WorkstreamEvents.
    /// </summary>
    [DataContract(Name = "FlattenedWorkstreamEvents")]
    public partial class FlattenedWorkstreamEvents : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedWorkstreamEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedWorkstreamEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedWorkstreamEvents" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="indices">This is a Map&lt;String, int&gt; where the the key is an activity id..</param>
        /// <param name="score">score.</param>
        public FlattenedWorkstreamEvents(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<ReferencedWorkstreamEvent> iterable = default(List<ReferencedWorkstreamEvent>), Dictionary<string, int> indices = default(Dictionary<string, int>), Score score = default(Score))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for FlattenedWorkstreamEvents and cannot be null");
            }
            this.Iterable = iterable;
            this.Schema = schema;
            this.Indices = indices;
            this.Score = score;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Iterable
        /// </summary>
        [DataMember(Name = "iterable", IsRequired = true, EmitDefaultValue = true)]
        public List<ReferencedWorkstreamEvent> Iterable { get; set; }

        /// <summary>
        /// This is a Map&lt;String, int&gt; where the the key is an activity id.
        /// </summary>
        /// <value>This is a Map&lt;String, int&gt; where the the key is an activity id.</value>
        [DataMember(Name = "indices", EmitDefaultValue = false)]
        public Dictionary<string, int> Indices { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedWorkstreamEvents {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Indices: ").Append(Indices).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
