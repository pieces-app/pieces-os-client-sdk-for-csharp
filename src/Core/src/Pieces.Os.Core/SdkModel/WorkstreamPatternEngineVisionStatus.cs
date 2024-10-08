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
    /// activation: can be active for forever w/ continous true, or it can be activated for the next couple hours  deactivation: here can be deactivated for forever w/ continuous true, or it can be deactivated for the next couple hours  Note: one or the other will be set and both are nullable.
    /// </summary>
    [DataContract(Name = "WorkstreamPatternEngineVisionStatus")]
    public partial class WorkstreamPatternEngineVisionStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamPatternEngineVisionStatus" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="activation">activation.</param>
        /// <param name="deactivation">deactivation.</param>
        public WorkstreamPatternEngineVisionStatus(EmbeddedModelSchema schema = default(EmbeddedModelSchema), AnonymousTemporalRange activation = default(AnonymousTemporalRange), AnonymousTemporalRange deactivation = default(AnonymousTemporalRange))
        {
            this.Schema = schema;
            this.Activation = activation;
            this.Deactivation = deactivation;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Activation
        /// </summary>
        [DataMember(Name = "activation", EmitDefaultValue = false)]
        public AnonymousTemporalRange Activation { get; set; }

        /// <summary>
        /// Gets or Sets Deactivation
        /// </summary>
        [DataMember(Name = "deactivation", EmitDefaultValue = false)]
        public AnonymousTemporalRange Deactivation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkstreamPatternEngineVisionStatus {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Activation: ").Append(Activation).Append("\n");
            sb.Append("  Deactivation: ").Append(Deactivation).Append("\n");
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
