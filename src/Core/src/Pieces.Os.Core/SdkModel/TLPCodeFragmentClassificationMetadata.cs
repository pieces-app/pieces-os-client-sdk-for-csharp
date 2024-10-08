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
    /// TLPCodeFragmentClassificationMetadata
    /// </summary>
    [DataContract(Name = "TLPCodeFragmentClassificationMetadata")]
    public partial class TLPCodeFragmentClassificationMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TLPCodeFragmentClassificationMetadata" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="context">context.</param>
        /// <param name="prior">prior.</param>
        public TLPCodeFragmentClassificationMetadata(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Classification context = default(Classification), Classification prior = default(Classification))
        {
            this.Schema = schema;
            this.Context = context;
            this.Prior = prior;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public Classification Context { get; set; }

        /// <summary>
        /// Gets or Sets Prior
        /// </summary>
        [DataMember(Name = "prior", EmitDefaultValue = false)]
        public Classification Prior { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TLPCodeFragmentClassificationMetadata {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Prior: ").Append(Prior).Append("\n");
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
