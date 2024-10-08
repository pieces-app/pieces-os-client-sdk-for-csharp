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
    /// This is a generic model that is used for text location.
    /// </summary>
    [DataContract(Name = "TextLocation")]
    public partial class TextLocation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextLocation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="text">this is the value that was found. (required).</param>
        /// <param name="start">this is the start index within the original string. (required).</param>
        /// <param name="end">this is the end index within the original string. (required).</param>
        public TextLocation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string text = default(string), int start = default(int), int end = default(int))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for TextLocation and cannot be null");
            }
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is the value that was found.
        /// </summary>
        /// <value>this is the value that was found.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// this is the start index within the original string.
        /// </summary>
        /// <value>this is the start index within the original string.</value>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = true)]
        public int Start { get; set; }

        /// <summary>
        /// this is the end index within the original string.
        /// </summary>
        /// <value>this is the end index within the original string.</value>
        [DataMember(Name = "end", IsRequired = true, EmitDefaultValue = true)]
        public int End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextLocation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
