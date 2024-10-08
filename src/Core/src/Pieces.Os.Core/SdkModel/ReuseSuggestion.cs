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
    /// This is the ReuseSuggestion. Mainly creating an additional model here because I imagine that we will want to add some additional data to this in the future (potentially with more numerical data that is emitted from the ML Models)  **Note: suggested is required here because we will want to say if we suggested to take this action of reuse or not.  ** Thoughts here. We could potentially return Assets: which would be an iterable of assets in most relavent order for the user to reuse if they want.
    /// </summary>
    [DataContract(Name = "ReuseSuggestion")]
    public partial class ReuseSuggestion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseSuggestion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReuseSuggestion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseSuggestion" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="suggested">This is a boolean, that will say if you should or should not take action. (required).</param>
        /// <param name="assets">assets (required).</param>
        public ReuseSuggestion(EmbeddedModelSchema schema = default(EmbeddedModelSchema), bool suggested = default(bool), Assets assets = default(Assets))
        {
            this.Suggested = suggested;
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for ReuseSuggestion and cannot be null");
            }
            this.Assets = assets;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is a boolean, that will say if you should or should not take action.
        /// </summary>
        /// <value>This is a boolean, that will say if you should or should not take action.</value>
        [DataMember(Name = "suggested", IsRequired = true, EmitDefaultValue = true)]
        public bool Suggested { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReuseSuggestion {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Suggested: ").Append(Suggested).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
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
