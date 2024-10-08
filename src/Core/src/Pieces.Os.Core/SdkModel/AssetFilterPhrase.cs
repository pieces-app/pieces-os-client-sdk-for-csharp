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
    /// AssetFilterPhrase
    /// </summary>
    [DataContract(Name = "AssetFilterPhrase")]
    public partial class AssetFilterPhrase : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetFilterPhrase" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="value">value.</param>
        /// <param name="annotation">annotation.</param>
        /// <param name="title">title.</param>
        /// <param name="content">content.</param>
        /// <param name="options">options.</param>
        public AssetFilterPhrase(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string value = default(string), bool annotation = default(bool), bool title = default(bool), bool content = default(bool), AssetFilterPhraseOptions options = default(AssetFilterPhraseOptions))
        {
            this.Schema = schema;
            this.Value = value;
            this.Annotation = annotation;
            this.Title = title;
            this.Content = content;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Annotation
        /// </summary>
        [DataMember(Name = "annotation", EmitDefaultValue = true)]
        public bool Annotation { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public bool Title { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public bool Content { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public AssetFilterPhraseOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetFilterPhrase {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
