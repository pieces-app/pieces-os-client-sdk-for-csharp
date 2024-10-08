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
    /// This is the low level seeded score and will let us know what exactly we want to increment on our material.  Note: ONLY include one of these, as we will only increment one of the following.
    /// </summary>
    [DataContract(Name = "SeededScore")]
    public partial class SeededScore : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededScore" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="reuse">reuse.</param>
        /// <param name="update">update.</param>
        /// <param name="reference">reference.</param>
        /// <param name="priority">priority.</param>
        /// <param name="searched">searched.</param>
        public SeededScore(EmbeddedModelSchema schema = default(EmbeddedModelSchema), bool reuse = default(bool), bool update = default(bool), bool reference = default(bool), bool priority = default(bool), bool searched = default(bool))
        {
            this.Schema = schema;
            this.Reuse = reuse;
            this.Update = update;
            this.Reference = reference;
            this.Priority = priority;
            this.Searched = searched;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Reuse
        /// </summary>
        [DataMember(Name = "reuse", EmitDefaultValue = true)]
        public bool Reuse { get; set; }

        /// <summary>
        /// Gets or Sets Update
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public bool Reference { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public bool Priority { get; set; }

        /// <summary>
        /// Gets or Sets Searched
        /// </summary>
        [DataMember(Name = "searched", EmitDefaultValue = true)]
        public bool Searched { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededScore {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Reuse: ").Append(Reuse).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
