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
    /// This is use as the score for an asset.  Manual: will be the raw sum of the asset activity events ranks with mechanismEnum &#x3D;&#x3D; manual Automatic: will be the raw sum of the asset activity events ranks with mechanismEnum &#x3D;&#x3D; automatic
    /// </summary>
    [DataContract(Name = "Score")]
    public partial class Score : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Score() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="manual">These are points assigned via manual user driven events. (required).</param>
        /// <param name="automatic">These are point assigned via automatic activity events. (required).</param>
        /// <param name="priority">priority.</param>
        /// <param name="reuse">reuse.</param>
        /// <param name="update">update.</param>
        /// <param name="reference">reference.</param>
        /// <param name="searched">searched.</param>
        public Score(EmbeddedModelSchema schema = default(EmbeddedModelSchema), int manual = default(int), int automatic = default(int), int priority = default(int), int reuse = default(int), int update = default(int), int reference = default(int), int searched = default(int))
        {
            this.Manual = manual;
            this.Automatic = automatic;
            this.Schema = schema;
            this.Priority = priority;
            this.Reuse = reuse;
            this.Update = update;
            this.Reference = reference;
            this.Searched = searched;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// These are points assigned via manual user driven events.
        /// </summary>
        /// <value>These are points assigned via manual user driven events.</value>
        [DataMember(Name = "manual", IsRequired = true, EmitDefaultValue = true)]
        public int Manual { get; set; }

        /// <summary>
        /// These are point assigned via automatic activity events.
        /// </summary>
        /// <value>These are point assigned via automatic activity events.</value>
        [DataMember(Name = "automatic", IsRequired = true, EmitDefaultValue = true)]
        public int Automatic { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Reuse
        /// </summary>
        [DataMember(Name = "reuse", EmitDefaultValue = false)]
        public int Reuse { get; set; }

        /// <summary>
        /// Gets or Sets Update
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = false)]
        public int Update { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public int Reference { get; set; }

        /// <summary>
        /// Gets or Sets Searched
        /// </summary>
        [DataMember(Name = "searched", EmitDefaultValue = false)]
        public int Searched { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Score {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Manual: ").Append(Manual).Append("\n");
            sb.Append("  Automatic: ").Append(Automatic).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Reuse: ").Append(Reuse).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Searched: ").Append(Searched).Append("\n");
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
