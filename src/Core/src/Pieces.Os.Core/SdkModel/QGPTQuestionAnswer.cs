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
    /// This will be a simple model with a score and a text value that will represent the value returned for this answer.
    /// </summary>
    [DataContract(Name = "QGPTQuestionAnswer")]
    public partial class QGPTQuestionAnswer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTQuestionAnswer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QGPTQuestionAnswer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTQuestionAnswer" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="score">This is the score from 0-1 on how good this answer is. (required).</param>
        /// <param name="text">text (required).</param>
        public QGPTQuestionAnswer(EmbeddedModelSchema schema = default(EmbeddedModelSchema), decimal score = default(decimal), string text = default(string))
        {
            this.Score = score;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for QGPTQuestionAnswer and cannot be null");
            }
            this.Text = text;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is the score from 0-1 on how good this answer is.
        /// </summary>
        /// <value>This is the score from 0-1 on how good this answer is.</value>
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public decimal Score { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTQuestionAnswer {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
