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
    /// This is used for the Sensitives searching endpoint.  sensitive here is only provided if transferables are set to true.  temporal: if this is provided this means that their material matched the input via a timestamp.  TODO will want to consider returning related materials to this material potentially both associated/ and not associated materials ie suggestion: WorkstreamSuggestions
    /// </summary>
    [DataContract(Name = "SearchedSensitive")]
    public partial class SearchedSensitive : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedSensitive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchedSensitive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedSensitive" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="sensitive">sensitive.</param>
        /// <param name="exact">exact (required).</param>
        /// <param name="similarity">similarity (required).</param>
        /// <param name="temporal">temporal.</param>
        /// <param name="identifier">This is the uuid of the sensitive. (required).</param>
        public SearchedSensitive(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Sensitive sensitive = default(Sensitive), bool exact = default(bool), decimal similarity = default(decimal), bool temporal = default(bool), string identifier = default(string))
        {
            this.Exact = exact;
            this.Similarity = similarity;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for SearchedSensitive and cannot be null");
            }
            this.Identifier = identifier;
            this.Schema = schema;
            this.Sensitive = sensitive;
            this.Temporal = temporal;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Sensitive
        /// </summary>
        [DataMember(Name = "sensitive", EmitDefaultValue = false)]
        public Sensitive Sensitive { get; set; }

        /// <summary>
        /// Gets or Sets Exact
        /// </summary>
        [DataMember(Name = "exact", IsRequired = true, EmitDefaultValue = true)]
        public bool Exact { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name = "similarity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Similarity { get; set; }

        /// <summary>
        /// Gets or Sets Temporal
        /// </summary>
        [DataMember(Name = "temporal", EmitDefaultValue = true)]
        public bool Temporal { get; set; }

        /// <summary>
        /// This is the uuid of the sensitive.
        /// </summary>
        /// <value>This is the uuid of the sensitive.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchedSensitive {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  Temporal: ").Append(Temporal).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
